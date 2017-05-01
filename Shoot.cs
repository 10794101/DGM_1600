using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

public Rigidbody projectile;
public Transform Spawnpoint;
public int shootSpeed;	
// Use this for initialization 
void Start (){

}
//update is called once per frame 
void Update (){
	if(Input.GetButtonDown("Fire1")){
		Rigidbody clone;
		clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, projectile.rotation);
		clone.velocity = Spawnpoint.TransformDirection (Vector3.forward*shootSpeed);
	}
}
}



