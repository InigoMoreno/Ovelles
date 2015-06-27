using UnityEngine;
using System.Collections;

public class Ovella : MonoBehaviour {

	private bool chocat;
	//public LlençarOvella aux;

	// Use this for initialization
	void Start () {
		chocat = false;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (gameObject.name);
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (!chocat) {
						LlencarOvella aux=transform.parent.GetComponent<LlencarOvella> ();
						aux.OvellaChoca();
						chocat = true;
				}
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.name.Contains ("Llop"))
						Destroy (gameObject);
	}
}
