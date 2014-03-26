using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI()
	{
		GUI.Label(new Rect(Screen.width/2 - 40, 150, 80, 50), "Game Over");
		if(GUI.Button(new Rect(Screen.width/2 - 40, Screen.height / 2, 80, 50),"Retry?"))
		{
			Application.LoadLevel(0);
		}
	}
}
