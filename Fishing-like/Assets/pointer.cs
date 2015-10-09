using UnityEngine;
using System.Collections;

public class pointer : MonoBehaviour {

	Transform objectPosition;
	
	// Use this for initialization
	void Start () {
		
		objectPosition = GameObject.Find ("Spoon").transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.LookAt(objectPosition.position);
		transform.position += Time.deltaTime/10 * transform.forward;
		
	}
}
