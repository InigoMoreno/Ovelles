using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public static SoundManager instance = null;
	public AudioSource music;
	public AudioSource effect;


	// Use this for initialization
	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);
		music.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevelName == "Level1")
			music.Stop ();
		else if (!music.isPlaying)
			music.Play (); 
	}

	public void playeffect (){
		effect.Play ();
	}
}
