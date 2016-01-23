using UnityEngine;
using System.Collections;

public class GenerateAttack : MonoBehaviour {
	public GameObject BulletPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			Instantiate(BulletPrefab , this.transform.position, this.transform.rotation);
		}
	}
}
