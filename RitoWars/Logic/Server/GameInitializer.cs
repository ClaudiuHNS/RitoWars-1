﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ENet;
using RitoWars.Logic.Game.Players;
using RitoWars.Logic.Json;
using RitoWars.Logic.Game.Champions;

namespace RitoWars.Logic.Server
{
    public class GameInitializer
    {
        [Obsolete]
        public Host Host;

        public UdpClient Server;

        public BlowFish BlowFish;

        public bool Initialized { get; private set; }

        List<PlayerInitJson> _bluePlayers, _redPlayers;

        public GameInitializer(IPEndPoint ipEndPoint, string serverKey, List<PlayerInitJson> teamBluePlayers, List<PlayerInitJson> teamRedPlayers)
        {
            //My goal is to try to stay away from enet because it is not 100% c#
            //Host = new Host();
            //Host.Initialize(ipEndPoint, 32);
            _bluePlayers = teamBluePlayers;
            _redPlayers = teamRedPlayers;
            foreach (var basicPlayer in teamBluePlayers)
            {
                GlobalData.TeamOnePlayers.Add(new Player {

                    ChampId = basicPlayer.ChampId,
                    PlayerChamp = new PlayerChamp
                    {
                        BaseChamp = BaseChamp.GetFromId(basicPlayer.ChampId)
                    }
                });
            }
            Server = new UdpClient(ipEndPoint);
            var key = Convert.ToBase64String(Encoding.UTF8.GetBytes(serverKey));
            if (key.Length <= 0){

                Initialized = false;
                return;
            }
            BlowFish = new BlowFish(Encoding.UTF8.GetBytes(key));
        }

        public void Loader()
        {
            while (true) {

                var endpoint = new IPEndPoint(IPAddress.Any, 0);
                var bytes = Server.Receive(ref endpoint);
                var decrypt = BlowFish.Decrypt_ECB(bytes);

            }
        }
    }
}
