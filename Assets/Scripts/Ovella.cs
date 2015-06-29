using UnityEngine;
using System.Collections;

public class Ovella : MonoBehaviour {

	private bool chocat;
	private LlencarOvella aux;

	void Awake () {
		aux = GameObject.Find ("Cullera catapulta").GetComponent <LlencarOvella> ();
	}

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
			aux.OvellaChoca();
			chocat = true;
		}
	}
	
	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.name.Contains ("Llop"))
						Destroy (gameObject);
	}
}
