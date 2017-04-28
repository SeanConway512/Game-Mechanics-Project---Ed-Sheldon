using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    
    

    public GameObject spell;
    public Transform ShootPoint;
    private float fireRate = 1f;

    private float nextFire;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(spell, ShootPoint.position, ShootPoint.rotation);
        }
    }
}
   

