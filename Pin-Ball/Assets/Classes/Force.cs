using UnityEngine;
using System.Collections;

public class Force : MonoBehaviour
{
    public Vector3 direction;
    public Rigidbody ball;
    public int gaatlos = -20;
    public float tijd = 0;
    public float handen;
    public int speed;
    public bool spd = false;

    public void Update()
        //my script for the bounce effect on the bumpers with a speedboost.
    {
        

        if (spd == true)
        {
            speed = 20;
            Tim();
        }
        else speed = 1;

        if (tijd > 2)
        {
            spd = true;
            handen = 0;
        }
            
        gaatlos = -1 * speed;
        
    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "sb")
        {
            spd = true;
            score.scoreh = score.scoreh + 10;

        }
        if (collision.collider.tag == "lol")
        {
            gaatlos = 0;
            score.scoreh = score.scoreh + 10;
        }

        if (collision.collider.tag == "lal")
        {
            gaatlos = gaatlos + 100;
            score.scoreh = score.scoreh + 25;

        }
            direction = collision.contacts[0].point;
            ball.AddForce(direction * gaatlos);
        
    }

    public void Tim()
    {
        handen = handen + 1;
        tijd = handen * Time.deltaTime;

    }
}