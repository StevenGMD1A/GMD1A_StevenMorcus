using UnityEngine;
using System.Collections;

public class flippermove : MonoBehaviour
{

    public bool flipactivated;
    public bool activeFlipper;
    public bool deactiveFlipper;
    public bool buttonhold;
    public bool endoftheline;
    public bool flipperactive;
    public float timer1 = 0;
    public float timer2 = 0;
    public float timerhold = 0;
    public GameObject flipperLinks;
    public GameObject flipperRechts;
    public Vector3 direction;
    public Vector3 startrotation;
    public Rigidbody ball;
    public int force;

    void Update()
    {
        if (Input.GetButton("Fire2") && flipactivated == false)
        {
            activeFlipper = true;
            buttonhold = true;
            flipactivated = true;
        }
        if (Input.GetButton("Fire2"))
        {
            buttonhold = false;
        }
        if (timer1 > 0.06f)
        {
            timer2 = timer1;
            activeFlipper = false;
            endoftheline = true;
            timer1 = 0;
        }
        if (buttonhold == false && endoftheline == true)
        {
            deactiveFlipper = true;
        }

        if (timer2 > 0.06f)
        {
            deactiveFlipper = false;
            timer2 = 0;
            flipactivated = false;
        }
        if (activeFlipper == true)
        {
            transform.RotateAround
                (transform.position,
                flipperLinks.transform.up,
                400 * Time.deltaTime);
            timer1 = timer1 + Time.deltaTime;
        }
        if (deactiveFlipper == true)
        {
            transform.RotateAround
               (transform.position,
               flipperLinks.transform.up,
               -400 * Time.deltaTime);
            timer2 = timer2 + Time.deltaTime;
            endoftheline = false;
        }
    }
}
