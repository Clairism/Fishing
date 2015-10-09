using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	private float speed;
	private float xSpeed;
	private float ySpeed;
	
	
	void Start () {
		
		speed = 5f;
		
	}
	
	void Update () {
		xSpeed = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		ySpeed = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		
		transform.Translate (Vector3.forward * xSpeed);
		transform.Translate (Vector3.left * ySpeed);

		if (Input.GetKey (KeyCode.Space)) {

			transform.Translate (Vector3.up * speed * Time.deltaTime);

		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			
			transform.Translate (Vector3.down * speed * Time.deltaTime);
			
		}

	}
}
