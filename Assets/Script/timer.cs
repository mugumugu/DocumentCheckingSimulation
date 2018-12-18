using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	private Text time;
	public int defaultHour = 12;
	float timeLeft = 0;

	void Start(){
		time = GetComponent<Text>();
	}

	void Update()
	{
		timeLeft += Time.deltaTime;
		time.text = defaultHour+":"+timeLeft.ToString("0");

		if(timeLeft >= 60)
		{
			// call function
		}
	}
 
 
	
}
