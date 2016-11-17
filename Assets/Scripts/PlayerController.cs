using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	private int count;
	public Text countText;
	public Text winText;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		winText.text = "";
		count = 0;
		countText.text = "Count: " + count.ToString ();
	}
	void FixedUpdate ()
    {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
    }
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Pick up"));
			other.gameObject.SetActive(false);
		count = count + 1;
		countText.text = "Count: " + count.ToString ();
		if (count >= 4) {
			winText.text = "You WIN!!!!";
		}
			
	}

      
}
