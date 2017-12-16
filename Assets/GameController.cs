using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	private void CleanupGame() {
		// Do some cleanup
	}

	public void EndGame() {
		CleanupGame ();
		SceneManager.LoadScene ("GameOver");
	}

}
