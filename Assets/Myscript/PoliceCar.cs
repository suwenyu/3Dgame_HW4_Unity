using UnityEngine;
using System.Collections;

public class PoliceCar : MonoBehaviour {
	public static float speedZ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Time.deltaTime * 10;
		transform.Translate (0, 0, translation);
		if (this.transform.position.z > 10.0f) {
			this.transform.Rotate (0,180 , 0);
		}
	}
}
