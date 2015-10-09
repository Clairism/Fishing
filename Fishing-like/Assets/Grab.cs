using UnityEngine;
using System.Collections;

public class Grab : MonoBehaviour {

		void OnTriggerEnter(Collider other){
			Destroy (gameObject.GetComponent<lerping2> ());
		}

}
