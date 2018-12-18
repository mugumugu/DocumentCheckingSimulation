using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holePunch : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip holeSFX;

	public SpriteRenderer pin;
	public Sprite original_pin,pushed_pin;

	void Start(){
		audioSource = GameObject.FindGameObjectWithTag("AudioSource").GetComponent<AudioSource>();
		pin = GameObject.FindGameObjectWithTag("holePuncher").transform.Find("pin").gameObject.GetComponent<SpriteRenderer>();
	}

	void OnMouseDown(){
		pin.sprite = pushed_pin;
		Destroy(GetComponent<BoxCollider2D>());
		audioSource.PlayOneShot(holeSFX);
	}

	void OnMouseUp(){
		pin.sprite = original_pin;
	}
}
