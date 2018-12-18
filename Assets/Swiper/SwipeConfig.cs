using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeConfig : MonoBehaviour {

	// public Swipe 
	public Swipe swipeControls;

	// Use this for initialization
	void Start () {
		swipeControls = GetComponent<Swipe>();
	}
	
	// Update is called once per frame
	// void Update () {
	// 	if(swipeControls.SwipeLeft)
	// 		Debug.Log("left:"+swipeControls.SwipeLeft);
	
	// 	if(swipeControls.SwipeRight)
	// 		Debug.Log("right:"+swipeControls.SwipeRight);
	
	// 	if(swipeControls.SwipeUp)
	// 		Debug.Log("up:"+swipeControls.SwipeUp);
	
	// 	if(swipeControls.SwipeDown)
	// 		Debug.Log("down:"+swipeControls.SwipeDown);	

	// 	if(swipeControls.Tap)
	// 		Debug.Log("tap:"+swipeControls.Tap);


	// }
}
