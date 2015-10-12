using UnityEngine;
using System.Collections;

public class Grab1 : MonoBehaviour {
	Transform GrabPosition;
	private bool entered;
	
	void Start(){
		GrabPosition = GameObject.Find ("Grab").transform;
	}
	
	void OnTriggerEnter(Collider other){
		entered = true;
	}
	void OnTriggerExit(Collider other){
		entered = false;
	}
	
	void Update () {
		
		if ( entered == true && Input.GetKey (KeyCode.G)) {
			Destroy (gameObject.GetComponent<lerping1> ());
			
			transform.LookAt(GrabPosition.position);
			transform.position += Time.deltaTime * transform.forward;
			
			
		}
		
		
	}

}
