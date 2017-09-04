using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Button startText;
	public Button exitText;
	public Button backText;
	public Canvas howToPlayText;
	public Canvas SelectPlayers;
	public Canvas StartMenu;
	public Button OnePlayer;
	public Button TwoPlayers;
	public Button back;
	public Canvas InfoOne;
	public Canvas InfoTwo;
	public Button OnePlayerInfo;
	public Button TwoPlayerInfo;
	public Button OnePlayerInfoBack;
	public Button TwoPlayerInfoBack;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
		backText = backText.GetComponent<Button> ();
		howToPlayText = howToPlayText.GetComponent<Canvas> ();
		howToPlayText.enabled = false;
		SelectPlayers = SelectPlayers.GetComponent<Canvas> ();
		SelectPlayers.enabled = false;
		StartMenu = StartMenu.GetComponent<Canvas> ();
		StartMenu.enabled = true;
		OnePlayer = OnePlayer.GetComponent<Button> ();
		TwoPlayers = TwoPlayers.GetComponent<Button> ();
		back = back.GetComponent<Button> ();
		InfoOne = InfoOne.GetComponent<Canvas> ();
		InfoOne.enabled = false;
		InfoTwo = InfoTwo.GetComponent<Canvas> ();
		InfoTwo.enabled = false;
		OnePlayerInfo = OnePlayerInfo.GetComponent<Button> ();
		TwoPlayerInfo = TwoPlayerInfo.GetComponent<Button> ();
		OnePlayerInfoBack = OnePlayerInfoBack.GetComponent<Button> ();
		TwoPlayerInfoBack = TwoPlayerInfoBack.GetComponent<Button> ();
	}
	
	public void onePlayerPress(){
		Application.LoadLevel (1);
	}

	public void twoPlayersPress(){
		Application.LoadLevel (2);
	}

	public void backPress2(){
		//StartMenu.enabled = true;
		SelectPlayers.enabled = false;
	}

	public void ExitPress(){
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;

	}

	public void NoPress(){
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

	public void InstructionPress(){
		howToPlayText.enabled=true;
		backText.enabled = true;
	}

	public void backPress(){
		howToPlayText.enabled = false;
		backText.enabled = false;
	}

	public void StartButton(){
		//StartMenu.enabled = false;
		SelectPlayers.enabled = true;
	}

	public void ExitGame(){
		Application.Quit ();
	}

	public void onePlayerInfo(){
		InfoOne.enabled = true;
		howToPlayText.enabled = false;
	}

	public void twoPlayerInfo(){
		InfoTwo.enabled = true;
		howToPlayText.enabled = false;
	}

	public void onePlayerInfoBack(){
		InfoOne.enabled = false;
		howToPlayText.enabled = true;
	}

	public void twoPlayerInfoBack(){
		InfoTwo.enabled = false;
		howToPlayText.enabled = true;
	}
}
