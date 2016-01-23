using UnityEngine;
using System.Collections;

public class ControlCharacter : MonoBehaviour {
	public static float characterX = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.W)) {
			this.transform.Translate (new Vector3 (1.0f , 0, 0));
		}
		if (Input.GetKeyUp (KeyCode.S)) {
			this.transform.Rotate(new Vector3(0 , 180 , 0));
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			this.transform.Rotate(new Vector3(0 , -30 , 0));
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			this.transform.Rotate(new Vector3(0 , 30 , 0));
		}
	}
}
