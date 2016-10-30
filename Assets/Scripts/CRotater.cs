using UnityEngine;
using System.Collections;

public class CRotater : MonoBehaviour {
	void Update() {
		transform.RotateAround(Vector3.zero, Vector3.up, 5000 * Time.deltaTime);
	}
}




// using UnityEngine; using System.Collections;

//public class CRotater : MonoBehaviour {
	
	// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	//void Update () {
		
		//transform.Rotate (new Vector2 (10, 15) * Time.deltaTime);
		
	//}
//}

