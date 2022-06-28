using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    //which enemy to attack
    public enum TargetPriority
    {
        First,
        Last,
        Close,
        Strong
    }
    public TargetPriority towerTarget;

    //which weapon for appropriate weapon stats
    public enum TowerWeapon
    {
        Ballista,
        Blaster,
        Cannon,
        Catapult
    }
    public TowerWeapon weaponType;

    /// <summary>
    /// each weapon's stats (seperate function with that info)
    /// includes speed, mt, reload time, etc.
    /// tower upgrades with differnet stats (specific towers with specific weapons or split them up with a tower multiplier)
    /// </summary>

    void Weapon()
    {
        /// <summary>
        /// find enemy depending on weapon's target priority
        /// find enemy speed and calculate where to aim arrow to collide with target
        /// reload timer based on upgrade
        /// </summary>
    }
}
