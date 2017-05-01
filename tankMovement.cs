﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class tankMovement : MonoBehaviour {
private int count;

public float moveSpeed;
public float turnSpeed;
public Text countText;

	// Use this for initialization
	void Start () {
		count= 0;
		SetCountText ();
	}
	
	// Update is called once per frame
	void Update () {
var x = Input.GetAxis("Horizontal")*Time.deltaTime*turnSpeed;
var z = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
transform.Rotate(0,x,0);
transform.Translate(0,0,z);	
	
		
	}
   void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
		count = count +1;
		SetCountText ();
    }



void SetCountText ()
{
countText.text = "Count: "+count.ToString ();
}
}