using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceMaker : MonoBehaviour {

    public string gender;

    public Sprite[] face, eyes, nose, lips, hair;

    public SpriteRenderer main_face, main_eyes, main_nose, main_lips, main_hair;

	// Use this for initialization
	void Start () {
        int r_face = Random.Range(0, face.Length),
            r_eyes = Random.Range(0, eyes.Length),
            r_nose = Random.Range(0, nose.Length),
            r_lips = Random.Range(0, lips.Length),
            r_hair = Random.Range(0, hair.Length);

        main_face.sprite = face[r_face];
        main_eyes.sprite = eyes[r_eyes];
        main_nose.sprite = nose[r_nose];
        main_lips.sprite = lips[r_lips];
        main_hair.sprite = hair[r_hair];
    }

    // Update is called once per frame
    void Update () {
		
	}
}
