using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonControler : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}

	// Intro
	public void PlayButton(){
		Application.LoadLevel (1);
		StartCoroutine (WaitPlay (1f));
	}
	IEnumerator WaitPlay (float seconds){
		yield return new WaitForSeconds(seconds);
		
		Button button = GameObject.Find("Solo").GetComponent<Button> ();
		button.onClick.AddListener (delegate {
			Campanya ();
		});
	}

	//Menu Principal
	public void Campanya(){
		Application.LoadLevel (2);
		StartCoroutine (WaitCampanya (1f));		
	}
	IEnumerator WaitCampanya (float seconds){
		yield return new WaitForSeconds(seconds);

		Button button = GameObject.Find("Jungle").GetComponent<Button> ();
		button.onClick.AddListener (delegate {
			Jungla ();
		});
	}

	//Seleccio de Mapes
	public void Jungla(){
		Application.LoadLevel (3);
		StartCoroutine (WaitJungla (1f));		
	}
	IEnumerator WaitJungla (float seconds){
		yield return new WaitForSeconds(seconds);
		
		Button button = GameObject.Find("Level 1").GetComponent<Button> ();
		button.onClick.AddListener (delegate {
			Level1 ();
		});
	}

	//Seleccio nivell
	public void Level1(){
		Application.LoadLevel (4);
	}

	public void ReturnButton(){
		Application.LoadLevel (Application.loadedLevel - 1);
	}


}