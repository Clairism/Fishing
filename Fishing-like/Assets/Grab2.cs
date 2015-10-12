using UnityEngine;
using System.Collections;

public class Grab2 : MonoBehaviour {

	private bool entered;


	void OnTriggerEnter(Collider other){
		entered = true;
	}
	void OnTriggerExit(Collider other){
		entered = false;
	}

	void Update () {

		if ( entered == true && Input.GetKey (KeyCode.G)) {
			Destroy (gameObject.GetComponent<lerping2> ());
					
		}
	
	}

}
