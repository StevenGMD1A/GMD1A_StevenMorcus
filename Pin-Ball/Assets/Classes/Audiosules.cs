using UnityEngine;
using System.Collections;

public class Audiosules : MonoBehaviour {
    public static int musiclist;
    public AudioSource egle;
    public bool egles;
    public AudioSource roknrol;
    public bool rokrol;
    public AudioSource remi;
    public bool remik;

    // Use this for initialization
    void Start () {
        AudioSource egle = GetComponent<AudioSource>();
        egle.Pause();
        AudioSource roknrol = GetComponent<AudioSource>();
        roknrol.Pause();
        AudioSource remi = GetComponent<AudioSource>();
        remi.Pause();
    }
	
	// Update is called once per frame
	void Update () {

        if (musiclist == 1)
        {
            egle.UnPause();
        }
        else egle.Pause();

        if (musiclist == 2)
        {
            roknrol.UnPause();
        }

        else roknrol.Pause();

        if (musiclist == 3)
        {
            remi.UnPause();
        }

        else remi.Pause();

        if (lifes.ded == true)
        {
            roknrol.Stop();
            egle.Stop();
            remi.Stop();
        }
    }
}
