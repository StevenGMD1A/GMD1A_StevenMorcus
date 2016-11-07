using UnityEngine;
using System.Collections;

public class Timelaunchpower : MonoBehaviour
{
    public float handig;
    public float tijdmachine;
    public string maxpower;
    public Vector3 force;
    public Rigidbody speler;
    public bool readytolaunch;

    // Update is called once per frame
    //script i made easily my counter starts reaches a max of 3 seconds and that times the force for a nice boost of power on hold.
    void Update()
    {
        if (readytolaunch == true
            &&
            Input.GetButtonUp("Jump")
            &&
            lifes.ded == false)
        {
            speler.AddForce(force * handig);

        }
        if (Input.GetButtonUp("Jump"))
        {
            readytolaunch = false;
        }
        if (Input.GetButton("Jump"))
            Tim();
        if (handig >= 3)
        {
            handig = 0;
            print(maxpower);
        }
    }
    public void Tim()
    {
        handig = handig + (1 * Time.deltaTime);
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "launcher")
        {
            readytolaunch = true;

        }
    }
}