using UnityEngine;
using System.Collections;

public class bikemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		speed = 1;
		moveThreshold = 0.2f;

		movex = 0;

		delay = 0.005f;

	}


	public Transform target;

	public float degrees=0;


	bool goleft,goright;




	float speed,moveThreshold,movex,iPx,delay,accel;


	// Update is called once per frame
	void Update () {


		iPx = Input.acceleration.x;




/*
	

		if(Mathf.Abs (iPx)>moveThreshold)
		{


			movex=Mathf.Sign (iPx)*speed;

			this.transform.Translate (Vector3.left * (movex));



		}

*/



		if (Input.GetKey (KeyCode.K)||iPx>delay) {
			goleft = true;
			goright = false;
			
		} else
		if (Input.GetKey (KeyCode.L)||iPx<-delay) {
			goleft = false;
			goright = true;
			
		} else {
			goleft=false;
			goright=false;
			
		}



		if (Mathf.Abs (iPx) < 1) {
						accel = iPx/2;
				}

	//	if (Input.GetKey (KeyCode.K)) {
		if(goleft)
		{

			if(Mathf.Abs(iPx)>delay)
						this.transform.Translate (Vector3.left * (-(accel-delay)));
		
		//	this.transform.Translate (Vector3.left * (0.05f));


						//	transform.RotateAround (target.position, Vector3.down, degrees * Time.deltaTime);
			//			degrees += 0.005f;
			
				} else
			
//		if (Input.GetKey (KeyCode.L)) {
			if(goright)
		{
			if(Mathf.Abs(iPx)>delay)
						this.transform.Translate (Vector3.left * (-(accel+delay)));


			//this.transform.Translate (Vector3.left * (-0.05f));


			//			degrees += 0.005f;

						//		transform.RotateAround (target.position, Vector3.forward, -degrees * Time.deltaTime);

				} else {
			degrees=0;
				}







		print (""+transform.position.x);


	
	}
}
