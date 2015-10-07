using UnityEngine;
using System.Collections;

public class Pointer : MonoBehaviour {

	Transform CubePosition;

	// Use this for initialization
	void Start () {

		CubePosition = GameObject.Find ("Cube").transform;
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.LookAt(CubePosition.position);
		transform.position += Time.deltaTime * transform.forward;

		//local/global position
		//transform.parent/setparent
	
	}
}
