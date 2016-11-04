using UnityEngine;
using System.Collections;

public class Canvasas : MonoBehaviour {
    public Canvas vera;
    public AudioSource tunes;


	// Use this for initialization
	void Start ()
    {
        AudioSource tunes = GetComponent<AudioSource>();
        tunes.Pause();
        vera.enabled = false;
        vera = GetComponent<Canvas>();
    }
	
	// Update is called once per frame
	void Update () {
	if(lifes.ded == true)
        {
            AudioSource tunes = GetComponent<AudioSource>();
            tunes.UnPause();
            vera.enabled = true;
            vera = GetComponent<Canvas>();
        }
	}
}
