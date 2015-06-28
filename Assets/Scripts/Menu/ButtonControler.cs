using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonControler : MonoBehaviour {
	public Sprite modeBackground;
	public Sprite mainBackground;
	public GameObject playButton;
	public Image background;
	public GameObject modeButtons;

	// Use this for initialization
	void Start () {
		modeButtons.SetActive (false);
		playButton.SetActive (true);
		background.sprite = mainBackground;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayButton(){
		playButton.SetActive (false);
		background.sprite = modeBackground;
		modeButtons.SetActive (true);
	}
}