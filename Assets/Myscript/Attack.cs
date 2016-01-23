using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
	public static float speedZ= 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//print("haha");
//		float translation = Time.deltaTime * 10;
//		transform.Translate(0, 0, translation);

		this.transform.Translate (new Vector3 (0, 0, speedZ));
		if (transform.position.z > 100.0f)
			Destroy (this.gameObject);
	}


}
