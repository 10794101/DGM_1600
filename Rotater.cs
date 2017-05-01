using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
	transform.Rotate (new Vector3 (1, 1, 90) * Time.deltaTime);
	}
}
