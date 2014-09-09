using UnityEngine;
using System.Collections;

public class objectmove : MonoBehaviour {




	Vector3 inipos;

	// Use this for initialization
	void Start () {
	
		inipos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	//	if(this.transform.position.z>-10)
		this.transform.Translate(Vector3.back*0.2f);
	//	else
	//		this.transform.Translate(Vector3.right*40);


	}
}
