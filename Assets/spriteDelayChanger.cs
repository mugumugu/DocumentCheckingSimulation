using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteDelayChanger : MonoBehaviour {

	public Sprite[] a;
	public float switchTime;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("switchRand",0,switchTime);
	}

	void switchRand(){
		GetComponent<SpriteRenderer>().sprite = a[Random.Range(0,a.Length)];
	}
}
