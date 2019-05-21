using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gun : MonoBehaviour
{
/* GUN Value Vars */
   public float gunDamage; //controls gun damage
   public float gunRange; //controls gun range
   public AudioClip gunShot; //audio for gunshot
   AudioSource source;

   public Sprite idleGun;
   public Sprite shotGun;
/* End of GUN Value Vars */

/* AMMO Vars */
    public AudioClip reloadGun; //audio for reload
    public AudioClip emptyGun; //audio for empty gun

    public int ammoAmount; //How much ammo the player has

    public int ammoClipSize; //max mag 

    private int ammoLeft; //ammo player has left
    private int ammoClipLeft; //ammo the clip has left

    bool isShot; //bool for shooting

    bool isReloading; //bool for reloading

    public Text ammoText; //text for ammo

/* End of AMMO Vars */

   void Awake() //initializes variables beofre the game starts
   {

       source = GetComponent<AudioSource>(); //get the audio source component
        ammoLeft = ammoAmount;
        ammoClipLeft = ammoClipSize;
   }


    void Update()
    {
        
        ammoText.text = ammoClipLeft + " / " + ammoLeft;
        if(Input.GetButtonDown("Fire1")) //fire1 = left mouse click
        {
            isShot = true;
        }

     



    }
   void FixedUpdate()
   {
       Ray raycast = Camera.main.ScreenPointToRay(Input.mousePosition); //sets the ray cast to the mouse
       RaycastHit hit;
       if(isShot == true && ammoClipLeft > 0 && isReloading == false){ 
        ammoClipLeft--;
        isShot = false;
        
        source.PlayOneShot(gunShot);


        if(Physics.Raycast(raycast, out hit, gunRange))
        {
            Debug.Log("I hit " + hit.collider.gameObject.name);
            hit.collider.gameObject.SendMessage("gunHit", gunDamage, SendMessageOptions.DontRequireReceiver);
        }

       }else if(isShot == true && ammoClipLeft <= 0) 
       {
           isShot = false;
           Reload();

       }
          if(Input.GetKeyDown(KeyCode.R))
       {
            Reload();
       }


       
    void Reload() //function for reloading gun
    {
        int bulletsToReload = ammoClipSize - ammoClipLeft;
        if(ammoLeft >= bulletsToReload)
        {
            StartCoroutine("ReloadWeapon");
            ammoLeft -= bulletsToReload;
            ammoClipLeft = ammoClipSize;

        } else if(ammoLeft < bulletsToReload && ammoLeft > 0)
            {   
                StartCoroutine("ReloadWeapon");
                ammoClipLeft += ammoLeft;
                ammoLeft = 0;

            } else if(ammoLeft <=0) //if no ammo is left play emptygun sound
                {
                    source.PlayOneShot(emptyGun);

                }

    }


   }
    IEnumerator ReloadWeapon()
    {
        isReloading = true;
        source.PlayOneShot(reloadGun);
        yield return new WaitForSeconds(2);
        isReloading = false;
    }

   IEnumerator shot()
   {
       GetComponent<SpriteRenderer>().sprite = shotGun;
       yield return new WaitForSeconds(0.1f); //suspends the coroutine execution for the given amount of seconds using scaled time
       GetComponent<SpriteRenderer>().sprite = idleGun;
   }

}
