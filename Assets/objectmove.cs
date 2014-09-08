using UnityEngine;
using System.Collections;

public class objectmove : MonoBehaviour {




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(this.transform.position.z>0)
		this.transform.Translate(Vector3.back*0.3f);
		else
			this.transform.Translate(Vector3.forward*60);


	}
}
