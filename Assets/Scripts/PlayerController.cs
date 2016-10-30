using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	public Text countText;
	
	private Rigidbody rb;
	private int count;
	public Text wintext;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		wintext.text = "";

	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pickup"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}
		void SetCountText ()
	{
		countText.text = "SCORE: " + count.ToString ();
		if (count >= 8)
		{
			wintext.text = "You Win!!";
		}
	}
		
	}
