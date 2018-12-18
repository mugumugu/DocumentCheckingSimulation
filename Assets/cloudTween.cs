using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudTween : MonoBehaviour {

	public float speed = 3f;
	public float destroyTime;

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * (Time.deltaTime * speed));
		Object.Destroy(gameObject, destroyTime);

	}
}
