using UnityEngine;
using System.Collections;

public class Destroy_Crates : MonoBehaviour {
	public GameObject debris;

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Projectile"){
				Instantiate(debris,transform.position,transform.rotation);
				Destroy (gameObject);
		}
	}

}