using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessRotation : MonoBehaviour {

    public float smooth = 0f;

	// Update is called once per frame
	void Update () {
        //        transform.Rotate(Vector3.forward * (smooth * Time.deltaTime));
        transform.Translate(Vector2.down * (smooth * Time.deltaTime));
	}
}
