using UnityEngine;
using System.Collections;

public class SphereClick : MonoBehaviour {

	public static int count = 4;

	void OnMouseDown () {
		GameObject.Destroy (this.gameObject);
		count--;
		if (count == 0) {
			Debug.Log("Done");
		}
	}

}
