using UnityEngine;
using System.Collections;

public class LerpingMover : MonoBehaviour {

	private Transform startPoint, endPoint;
	public float percentage;
	public float speed =2;

	private int direction;


	void Start () {

		startPoint = GameObject.Find ("Start Point").transform;
		endPoint = GameObject.Find("End Point").transform;
	
		direction = 1;
	}
	
	void Update () {
		//linear interplotation -- lerp
		transform.position = Vector3.Lerp(startPoint.position, endPoint.position, percentage);
		transform.rotation = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler( new Vector3(-90,120,3) ), percentage );

		gameObject.GetComponent<Renderer>().material.color = Color.Lerp (Color.cyan, Color.yellow, percentage);

		//error catcher
//		if(speed == 0) speed = .000001f;

		speed = Mathf.Max(speed, .000001f);

		percentage += Time.deltaTime/speed * direction;
		if ((percentage > 1) || (percentage < 0)){
//			percentage = 0;
			direction *= -1;
			percentage = Mathf.Clamp(percentage,0,1);
		}
//reverse direction
//		if(percentage <= 0){
//			direction *= -1;
//		}
	}
}
