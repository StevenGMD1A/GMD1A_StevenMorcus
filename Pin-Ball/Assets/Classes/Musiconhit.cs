using UnityEngine;
using System.Collections;

public class Musiconhit : MonoBehaviour {

    // Update is called once per frame
    void Update() {

    }
    //getting the int to change because of musiclist changing making other songs unpause.
     public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "1")
        {
            Audiosules.musiclist = 1;
            score.scoreh = score.scoreh + 10;
        }

        if (collision.gameObject.tag == "2")
        {
            Audiosules.musiclist = 2;
            score.scoreh = score.scoreh + 10;
        }
        if (collision.gameObject.tag == "3")
        {
            Audiosules.musiclist = 3;
            score.scoreh = score.scoreh + 10;
        }
    }
}
