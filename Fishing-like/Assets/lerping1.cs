using UnityEngine;
using System.Collections;

public class lerping1 : MonoBehaviour {
	private Transform startPoint, endPoint;
	public float percentage;
	public float lower =10;
	
	private int direction;
	
	
	void Start () {
		
		startPoint = GameObject.Find ("start1").transform;
		endPoint = GameObject.Find("end1").transform;
		
		direction = 1;
	}
	
	void Update () {
		
		transform.position = Vector3.Lerp(startPoint.position, endPoint.position, percentage);
		//transform.rotation = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler( new Vector3(-90,120,3) ), percentage );
		
		//		gameObject.GetComponent<Renderer>().material.color = Color.Lerp (Color.cyan, Color.yellow, percentage);
		
		
		lower = Mathf.Max(lower, .000001f);
		
		percentage += Time.deltaTime/lower * direction;
		if ((percentage > 1) || (percentage < 0)){
			direction *= -1;
			percentage = Mathf.Clamp(percentage,0,1);
		}
		
	}
}
