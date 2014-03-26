using UnityEngine;
using System.Collections;

public class ExplosionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ExplosionDoneEvent()
	{
		Destroy(this.gameObject);
		Application.LoadLevel(1);

	}

}
