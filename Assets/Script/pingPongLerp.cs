using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pingPongLerp : MonoBehaviour {

    private Transform attacher;
    public float hight = 10f;//max height of Box's movement
    public float yCenter = 0f;

    void Start()
    {
        attacher = transform;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, yCenter + Mathf.PingPong(Time.deltaTime * 0.5f, hight) - hight / 2f, transform.position.z);//move on y axis only
                                                                                                                                                  //Box is moving with Mathf.PingPong (http://docs.unity3d.com/Documentation/ScriptReference/Mathf.PingPong.html)
    }
}
