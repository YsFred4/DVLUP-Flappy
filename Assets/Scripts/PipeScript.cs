using UnityEngine;
using System.Collections;

public class PipeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		this.rigidbody2D.velocity = (-Vector2.right * 1f);
	}
	
	// Update is called once per frame
	void Update () {
//		this.rigidbody2D.AddForce(-Vector2.right * 0.2f);
		this.rigidbody2D.velocity = (-Vector2.right * 1f);
	}
}
