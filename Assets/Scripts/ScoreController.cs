using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {
	private static int Score;
	// Use this for initialization
	void Start () {
		Score=0;
		Debug.Log (gameObject.name);
	}
	
	public static void AddScore (int addedScore){
		Score+=addedScore;
		GameObject.FindGameObjectWithTag("Score").GetComponent<Text>().text="Puntuació: "+Score;
	}
}
