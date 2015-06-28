using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonControler : MonoBehaviour {
	public Sprite modeBackground;
	public GameObject playButton;
	public Image background;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayButton(){
		playButton.SetActive (false);
		background.sprite = modeBackground;
	}
}