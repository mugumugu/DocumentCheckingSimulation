using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMaker : MonoBehaviour {

	public GameObject cloud;
	public float reps =4f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("makeCloud",0,reps);
	}

	void makeCloud(){
		Instantiate(cloud,transform.position,transform.rotation,GameObject.FindGameObjectWithTag("BlockerMain").transform);
	}
}
