using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonControler : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}

	public void PlayButton(){
		Application.LoadLevel (1);
		StartCoroutine (WaitPlay (2f));		
	}
	IEnumerator WaitPlay (float seconds){
		yield return new WaitForSeconds(seconds);
		
		Button button = GameObject.Find("Solo").GetComponent<Button> ();
		button.onClick.AddListener (delegate {
			Campanya ();
		});
		Debug.Log ("ok");
	}

	public void Campanya(){
		Application.LoadLevel (2);
		StartCoroutine (WaitCampanya (2f));		
	}
	IEnumerator WaitCampanya (float seconds){
		yield return new WaitForSeconds(seconds);

		Button button = GameObject.Find("Jungle").GetComponent<Button> ();
		button.onClick.AddListener (delegate {
			Jungla ();
		});
	}

	public void Jungla(){
		Application.LoadLevel (3);
	}

	public void ReturnButton(){

	}


}