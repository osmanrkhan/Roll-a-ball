using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	// That should define player and tell the script what it is
	private Vector3 offset;
	// Vector3 offset will 
	void Start () {
		offset = transform.position - player.transform.position;
		// offset now equal to campos - spherepos
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;	
		//use that bit of code to set new campos every frame using lateupdate
	}
}
