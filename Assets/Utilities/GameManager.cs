using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager> {

	[SerializeField] private Player currentPlayer;
	
	public Player CurrentPlayer{
		get { return currentPlayer ;}
	}

	private void Awake(){
		Assert.IsNotNull(currentPlayer);
	}

	public void LoadMainScene(){
		SceneManager.LoadScene(PocketDroidConstants.SCENE,LoadSceneMode.Additive);

	}
}
