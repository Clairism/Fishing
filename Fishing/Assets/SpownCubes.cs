using UnityEngine;
using System.Collections;
using UnityEngine.UI;  // import UI library

public class SpownCubes : MonoBehaviour {

	public GameObject cubeToSpawn;
	public Slider cubeSliderCounter;

	private string[] names = { "yoyo", "hoho", "yeahyeah", "nono", "coolcool" };

	public void buttonMakeCubes(){

		//value is a float
		//converting the float to int
		int numCubes = Mathf.RoundToInt( cubeSliderCounter.value );

		//start = 0; count max = what the slider set to
		//count by 1

		for ( int count = 0; count < numCubes; count ++ ) {

			GameObject justSpawnedCube = Instantiate(cubeToSpawn, Random.insideUnitSphere * 10f, Quaternion.identity) as GameObject;
			//justSpawnedCube.GetComponent<Rigidbody>().AddForce(Random.insideUnitSphere * 5f);


			//pick a random name & won't break it with adding names in the array
			justSpawnedCube.GetComponentInChildren<Text>().text = names[Random.Range(0, names.Length)];
		}
	}
}
