using UnityEngine;
using System.Collections;

public class toEating : MonoBehaviour {

	private float point;

	void Start(){
		point = 0;

	}
	void Update () {
		
		if ( point >= 3) {
			Application.LoadLevel("Eating");
		}
		
	}

	void OnTriggerEnter (Collider other){
		point += 1;
		print (point);
	}
}
