using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {
	
	public AudioSource audioSource;
	public AudioClip ovellaVolant;
	public AudioClip catapulta;
	public AudioClip encertar;

	public void play (string s){
		if (s.Equals("ovella volant")){
			audioSource.clip=ovellaVolant;
		}
		else if (s.Equals("catapulta")){
			audioSource.clip=catapulta;
		}
		else if (s.Equals("encertar")){
			audioSource.clip=encertar;
		}
		audioSource.Play();
	}
}
