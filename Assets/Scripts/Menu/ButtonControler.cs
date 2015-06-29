using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonControler : MonoBehaviour {
	private SoundManager soundmanager;

	void Awake(){
		soundmanager = GameObject.Find ("SoundManager").GetComponent<SoundManager> ();
	}

	// Intro
	public void PlayButton(){
		soundmanager.playeffect ();
		Application.LoadLevel (1);
	}

	//Menu Principal
	public void Campanya(){
		soundmanager.playeffect ();
		Application.LoadLevel (2);

	}

	//Seleccio de Mapes
	public void Jungla(){
		soundmanager.playeffect ();
		Application.LoadLevel (3);	
	}

	//Seleccio nivell
	public void Level1(){
		soundmanager.playeffect ();
		Application.LoadLevel (4);
	}

	//Return
	public void ReturnButton(){
		soundmanager.playeffect ();
		int act = Application.loadedLevel;
		Application.LoadLevel (act - 1);
	}


}