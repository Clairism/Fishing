using UnityEngine;
using System.Collections;

public class IntoPlate2 : MonoBehaviour {
	private Transform startPoint, endPoint;
	private float percentage;
	private float y;
	
	void Start (){
		
		startPoint = GameObject.Find ("potato").transform;
		endPoint = GameObject.Find("potato plate").transform;
		
		y = startPoint.position.y;
		percentage = 0.1f;
		
	}
	
	void Update(){
		if (y >= 1f) {

			transform.position = Vector3.Lerp (startPoint.position, endPoint.position, percentage);

		}

		if (percentage >= 1) {
			percentage = 0;
		}
		
	}
}
