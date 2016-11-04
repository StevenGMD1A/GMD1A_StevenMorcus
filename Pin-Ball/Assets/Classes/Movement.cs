using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public float speed;
    public Vector3 moving;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump")) {
            Vector3 d = moving * speed * Time.deltaTime;
            transform.Translate(d);
        }
    }
}
