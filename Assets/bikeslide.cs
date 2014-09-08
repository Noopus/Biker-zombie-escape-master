﻿using UnityEngine;
using System.Collections;

public class bikeslide : MonoBehaviour {

	public Transform spine;
	
	
	
	
	
	float roty;
	
	Vector3 iniangles,curangles;
	
	void Start ()
	{
		
		iniangles = transform.eulerAngles;
		
		curangles = Vector3.zero;
		
		roty = 0;
		
		
	}
	
	
	
	bool goleft,goright;

	
	float iPx;
	
	
	void Update ()
	{
		
		
		
		iPx = Input.acceleration.x;
		
		
		
		Vector3 rot = spine.rotation.eulerAngles;
		// Detect key input and add or subtract from the x rotation (scaling
		// by deltaTime to make this speed independent from the frame rate)
		
		
		if (Input.GetKey (KeyCode.K)||iPx<-0.05f) {
			goleft = true;
			goright = false;
			
		} else
		if (Input.GetKey (KeyCode.L)||iPx>0.05f) {
			goleft = false;
			goright = true;
			
		} else {
			goleft=false;
			goright=false;
			
		}
		
		
		
		//		if (Input.GetKey (KeyCode.K)) {
		if(goleft)
		{
			//		rot.z += Time.deltaTime * 30.0f;
			
			//		this.transform.Translate (Vector3.left * 0.1f);
			
			curangles.y -= 10*(2+Mathf.Abs(iPx/2)) * Time.deltaTime;
			
			
		} else
			
			//	if (Input.GetKey (KeyCode.L)) {
			
			if(goright)
		{
			//		rot.z -= Time.deltaTime * 30.0f;
			//		this.transform.Translate (-Vector3.left * 0.1f);
			
			curangles.y += 10*(2+Mathf.Abs(iPx/2)) * Time.deltaTime;
			
			
			
		} else {
			
			
			if (curangles.y < -0.01f)
				curangles.y += 30 * Time.deltaTime;
			if (curangles.y > 0.01f)
				curangles.y -= 30 * Time.deltaTime;

		}
		
		
		
		/*
		if(!Input.GetKey(KeyCode.L)&&!Input.GetKey(KeyCode.K))
		if(rot.y<270)
		{
			
			rot.y+=Time.deltaTime*10;
		}
		else
			
			if(rot.y>270)
		{
			
			rot.y-=Time.deltaTime*10;
		}

		*/
		
		
		// Apply the new rotation
		//spine.rotation = Quaternion.Euler(rot);
		
		curangles.x=Mathf.Clamp(curangles.x,-25,25);
		
		curangles.y=Mathf.Clamp(curangles.y,-10,10);
		
		curangles.z=Mathf.Clamp(curangles.z,-25,25);
		
		
		
		transform.eulerAngles=iniangles+curangles;
		
		
		
		
		//		spine.localRotation = Quaternion.Euler (rot);
	} 
	
	
}
