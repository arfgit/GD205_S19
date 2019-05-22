using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public int hP; //health for fans

    public bool attack; //monster attack

    public bool shoot; //monster projectile

    public float attackDamage; //var for attack damage

    public float rangeDamage; //var for ranged attacks


    public void gunHit(int gunDamage)
    {
        Debug.Log("I hit " + gunDamage);
        hP = hP - gunDamage;


    }

    void Death(){
        if(hP <= 0)
        {
            Die();
        }


    }

    void Die()
    {


        
    }


}
