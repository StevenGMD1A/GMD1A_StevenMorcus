﻿using UnityEngine;
using System.Collections;

public class Flipperness2 : MonoBehaviour {
    public bool flipperactivatedleft;
    public bool flipperactivatedright;
    public float counterleft;
    public float counterright;
    public int handen = 1;
    public Rigidbody speler;
    public Vector3 force;
    public bool hit;
    public bool timershot;

    // Update is called once per frame
    void Update () {
        
        if (counterleft >= 0.06f)
        {
            timershot = false;
            counterleft = 0;
            handen = 0;
            hit = false;
        }
        if (timershot == true)
        {
            Tim();
        }
        else
            handen = 0;

        if (Input.GetButton("Fire1"))
        {
            timershot = true;
            flipperactivatedleft = true;
        }
        else
        {
            timershot = false;
            counterleft = 0;
            flipperactivatedleft = false;
            handen = 0;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "ball")
        {
            speler.AddForce(force * 1000 * counterleft);
            hit = true;
        }
        else hit = false;
    }
    public void Tim()
    {
        handen = handen + 1;
        counterleft = handen * Time.deltaTime;
    }
}
