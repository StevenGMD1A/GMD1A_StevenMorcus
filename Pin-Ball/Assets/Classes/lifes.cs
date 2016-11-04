using UnityEngine;
using System.Collections;

public class lifes : MonoBehaviour {
    public int lifez = 3;
    public Vector3 respawnpoint;
    public static bool ded;

	// Update is called once per frame
	void Update () {
	
	}
    public void OnCollisionEnter(Collision collision)
    {
    if(collision.collider.tag == "Respawn")
        {
            transform.position = respawnpoint;
            lifez = lifez - 1;
        }
    if (lifez == 0)
        {
            ded = true;
        }
    }
}

