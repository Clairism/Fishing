using UnityEngine;
using System.Collections;

public class IntoPlate1 : MonoBehaviour {

	private Transform startPoint, endPoint;

	private float x;
	private float y;

	void Start (){

		startPoint = GameObject.Find ("potato").transform;
		endPoint = GameObject.Find("potato plate").transform;

		x = gameObject.transform.position.x;
		y = gameObject.transform.position.y;

	}

	void Update(){
		if (y >= 3) {

			x = endPoint.position.x;
			y = 1;

			//transform.position = Vector3.Lerp (startPoint.position, endPoint.position, percentage);

		}

	}
}

