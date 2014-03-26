using UnityEngine;
using System.Collections;
using System.Timers;

public class PlayerScript : MonoBehaviour {

	public int speed;
	public GameObject explosion;
	public GameObject pipes;
	public Transform pipeStart;

	void MakePipe()
	{
		object p = Instantiate(pipes, pipeStart.position, Quaternion.identity);
		Destroy((GameObject)p, 14f);
		Invoke("MakePipe", 10.0f);
	}

	// Use this for initialization
	void Start () {
		Invoke("MakePipe", 1.0f);
	}

	void ApplyForce()
	{
		this.rigidbody2D.AddForce(Vector2.up * speed);
	}

	void DestroyShip()
	{
		Vector3 pos = this.gameObject.transform.position;
		Destroy(this.gameObject);
		Object exp = Instantiate(explosion,pos, Quaternion.identity);
		//Destroy((GameObject)exp,1.1f);
	}

	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			DestroyShip();
		}
		if(Input.GetKeyDown(KeyCode.B))
		{
			object p = Instantiate(pipes, pipeStart.position, Quaternion.identity);
			Destroy((GameObject)p, 20f);
		}

		if(Input.GetKeyDown(KeyCode.Space))
		{
			ApplyForce();
		}
		if(Input.GetMouseButtonDown(0))
		{
			ApplyForce();
		}

		if(Input.touchCount == 1)
		{
			Touch t = Input.GetTouch(0);
			if(t.phase == TouchPhase.Began)
			{
				ApplyForce();
			}
		}
	}

	void OnCollisionEnter2D(Collision2D theCollision)
	{
		if (theCollision.gameObject.tag == "pipes")
		{
			DestroyShip();
//			AudioSource.PlayClipAtPoint(explosionSFX, transform.position);
		}
	}

}







