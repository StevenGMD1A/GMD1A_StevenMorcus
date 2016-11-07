using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public static int scoreh;
    public Text tekst;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    //basic script for score.
	void Update () {
        tekst.text = scoreh.ToString();

    }
}
