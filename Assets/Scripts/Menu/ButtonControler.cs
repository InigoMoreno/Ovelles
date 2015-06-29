using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonControler : MonoBehaviour {

	// Intro
	public void PlayButton(){
		Application.LoadLevel (1);
	}

	//Menu Principal
	public void Campanya(){
		Application.LoadLevel (2);

	}

	//Seleccio de Mapes
	public void Jungla(){
		Application.LoadLevel (3);	
	}

	//Seleccio nivell
	public void Level1(){
		Application.LoadLevel (4);
	}

	//Return
	public void ReturnButton(){
		int act = Application.loadedLevel;
		Application.LoadLevel (act - 1);
	}


}