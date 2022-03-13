using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit
{
    [SerializeField]public string UnitName, faction;
    [SerializeField]public int level;

    public Unit Combat(Unit opponent)
    {
        Unit result = new Unit();
        if (opponent.level >= this.level)
        {
            Die();
            opponent.level += this.level;
            result = opponent;
        }
        else
        {
            level += opponent.level;
            result = this;
            //Destroy(opponent.gameObject);
        }
        return result;
    }
    public virtual void Die()
    {
        Debug.Log("se murio");
    }
}