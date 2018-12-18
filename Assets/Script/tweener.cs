using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tweener : MonoBehaviour {

	public float speed = 3f;
	public Transform lastPos,originalPos;
	public int moveInt = 0;

	public bool isNotPaper;
	public bool allowClickEvent = false;
	public bool positionReached;
	Transform tgt;

	void Start(){
		if(!isNotPaper)
			moveInt = 1;
	}

	public void changeMove(){
		if(moveInt==0)
			moveInt = 1;
		else if(moveInt==1)
			moveInt = 2;
		else if(moveInt==2)
			moveInt = 1;
	}
	
	void OnMouseDown(){
		if(allowClickEvent)
			changeMove();
	}

	void LateUpdate () {
		if(moveInt==1)
			tgt = lastPos;
		else if(moveInt==2||moveInt==0)
			tgt = originalPos;

		positionReached = (Vector3.Distance(transform.position,tgt.position) < 0.1f);

		if(!positionReached)
			transform.position = Vector3.Lerp(transform.position,tgt.position,Time.deltaTime * speed);

		if(moveInt==2 && positionReached){
			if(!isNotPaper)
				Destroy(this.gameObject);
		}
	}
}
