
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ultimatespell : MonoBehaviour
{



    public GameObject spell1, spell2, spell3;
    public Transform ShootPoint;
    private float fireRate1 = 2f;
    private float fireRate2 = 0.5f;
    private float fireRate3 = 0.1f;
    private float nextFire;

    // Update is called once per frame
    void Update()
    {
            
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate1;
            Instantiate(spell1, ShootPoint.position, ShootPoint.rotation);
            for(int forward = 0; forward < 50; forward++)
            {

                spell1.transform.position += new Vector3(1, 0, 1);

            }
        }
        if (Input.GetButton("Fire2") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate2;
            Instantiate(spell2, ShootPoint.position, ShootPoint.rotation);
            for(int forward = 0; forward < 50; forward++)
            {

                spell2.transform.position += new Vector3(1, 0, 1);

            }
        }
        if (Input.GetButton("Fire3") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate3;
            Instantiate(spell3, ShootPoint.position, ShootPoint.rotation);
            for(int forward = 0; forward < 50; forward++)
            {

                spell3.transform.position += new Vector3(1, 0, 1);

            }
        }
    }
    }

