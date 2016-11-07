using UnityEngine;
using System.Collections;

public class Flipperness : MonoBehaviour
{
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
    void Update()
    {
        //My try of getting a script for applying force to a ball with not a constant force but a force adding up how later you hit the ball.
        //The input of the button starts a timer that resets after a short period of time hopefully the time it takes for the flipper to reach its rotation

        if (Input.GetButton("Fire2"))
        {
            timershot = true;
            flipperactivatedright = true;
        }
        else
        {
            timershot = false;
            counterright = 0;
            flipperactivatedright = false;
            handen = 0;
        }
        if (counterright >= 0.06f)
        {
            timershot = false;
            counterright = 0;
            handen = 0;
            hit = false;
        }
        if (counterleft >= 0.06f)
        {
            timershot = false;
            counterright = 0;
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
            speler.AddForce(force *1000 * counterright);
            hit = true;
        }
        else hit = false;
    }
    public void Tim()
    {
        handen = handen + 1;
        counterright = handen * Time.deltaTime;
    }
}
