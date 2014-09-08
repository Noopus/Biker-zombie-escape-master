using UnityEngine;
using System.Collections;

public class undergroundmove : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	public float speed = 0.9f;
	
	
	
	public bool isroad=true;
	
	
	int count;
	
	//Offset the material texture at a constant rate
	void LateUpdate () {
		
		count = (int)Time.time;
		
	//	print("My Counter : "+count);
		
		
		
		
		float offset = Time.time * speed;                            
		
		
		if (count > 5) {
			
			if(isroad)
	
				renderer.material.mainTextureOffset = new Vector2 (0, -offset);
			    



		} else {
		



			if(isroad)
				transform.Translate(new Vector3 (0,0, -offset/40));
			else
				transform.Translate(new Vector3 (0, -offset/40,0));

			
			
		}
		
		
		//	renderer.material.SetTextureOffset("_QOffset",new Vector2(0, -offset));
		
		//	renderer.material.SetTextureOffset("_MainTex",new Vector2(.25f,.15f));
		
		
		
		
	}
}