using UnityEngine;
using System.Collections;

public class Movable : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
	}

	void OnMouseDown () {
		float thrust = 8000f;
		rb.AddForce(transform.forward * thrust);
	}

	void Update() {
		if (Input.GetKey(KeyCode.LeftArrow)) {
			this.transform.position = new Vector3(transform.position.x-0.05f, transform.position.y, transform.position.z);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			this.transform.position = new Vector3(transform.position.x+0.05f, transform.position.y, transform.position.z);
		}
	}
}
