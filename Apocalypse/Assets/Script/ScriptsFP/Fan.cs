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

    SpriteRenderer sr;


    void Start()
    {

        sr=GetComponent<SpriteRenderer>();

    }
    public void gunHit(int gunDamage)
    {
        Debug.Log("I hit " + gunDamage);
        
        hP = hP - gunDamage;
        
        Death();

    }


    void Death(){
        if(hP <= 0)
        {
             Destroy(gameObject);
            
        }


    }



}
