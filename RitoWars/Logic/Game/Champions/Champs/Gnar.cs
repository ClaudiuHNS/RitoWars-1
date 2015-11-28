using RitoWars.Logic.Game.Champions.Helpers;

namespace RitoWars.Logic.Game.Champions.Champs
{
    public abstract class Gnar : BaseChamp
    {
        #region ChampData
        /// <summary>
        /// The champion name
        /// </summary>
        public override string ChampName => "Gnar";

        /// <summary>
        /// The champion id
        /// </summary>
        public override int ChampId => 150;

#endregion ChampData

        #region Health
        /// <summary>
        /// The champion's base health at level one
        /// </summary>
        public override double BaseHealth => 540;

        /// <summary>
        /// The champion's health gained for leveling up
        /// </summary>
        public override double HealthLevel => 65;

        /// <summary>
        /// The champion's amount of health regen
        /// </summary>
        public override double BaseHealthRegen => 2.5;

        /// <summary>
        /// The champion's health regen gained for leveling up
        /// </summary>
        public override double HealthRegenLevel => 0.5;
        #endregion Health

        #region SecondaryBar
        /// <summary>
        /// The champion's <seealso cref="SecondaryBar"/> resource the champion has
        /// </summary>
        public override SecondaryBar SecondaryBar => SecondaryBar.Fury;

        #region SecondaryBarData
        /// <summary>
        /// The champion's base <seealso cref="SecondaryBar"/> amount
        /// </summary>
        public override double BaseSecondaryBarData => 100;

        /// <summary>
        /// The champion's <seealso cref="SecondaryBar"/> amount gained for leveling up
        /// </summary>
        public override double SecondaryBarDataLevel => 0;

        /// <summary>
        /// The champion's <seealso cref="SecondaryBar"/> base regen amount
        /// </summary>
        public override double BaseSecondaryBarRegen => 0;

        /// <summary>
        /// The champion's <seealso cref="SecondaryBar"/> regen amount gained for leveling up
        /// </summary>
        public override double SecondaryBarRegenLevel => 0;
        #endregion SecondaryBarData
        #endregion SecondaryBar

        #region Attacks 
        /// <summary>
        /// The champion's base attack damage
        /// </summary>
        public override double BaseAttackDamage => 48;

        /// <summary>
        /// The champion's attack damage gained for leveling up
        /// </summary>
        public override double AttackDamageLevel => 3;

        /// <summary>
        /// The champion's base attack speed
        /// </summary>
        public override double BaseAttackSpeed => 0.625; 

        /// <summary>
        /// The champion's attack speed percent gained for leveling up
        /// </summary>
        public override double AttackSpeedPercent => 6; 

        /// <summary>
        /// The champion's auto attack range
        /// </summary>
        public override double AutoAttackRange => 150; 
        #endregion Attacks

        #region Defense
        /// <summary>
        /// The champion's base armor
        /// </summary>
        public override double BaseArmor => 23;

        /// <summary>
        /// The champion's armor gained for leveling up
        /// </summary>
        public override double ArmorLevel => 2.5;

        /// <summary>
        /// The champion's base magic resist (for most champions is 30)
        /// </summary>
        public override double BaseMagicResist => 30;

        /// <summary>
        /// The champion's magic resist gained for leveling up
        /// </summary>
        public override double MagicResistLevel => 0;
        #endregion Defense

        #region CastingResource
        /// <summary>
        /// The champion's <seealso cref="CastingResource"/> for using Q
        /// </summary>
        public override CastingResource Q => CastingResource.NoCastingResource;

        /// <summary>
        /// The champion's <seealso cref="CastingResource"/> for using W
        /// </summary>
        public override CastingResource W => CastingResource.NoCastingResource;

        /// <summary>
        /// The champion's <seealso cref="CastingResource"/> for using E
        /// </summary>
        public override CastingResource E => CastingResource.NoCastingResource;

        /// <summary>
        /// The champion's <seealso cref="CastingResource"/> for using R
        /// </summary>
        public override CastingResource R => CastingResource.NoCastingResource;
        #endregion CastingResource
    }
}