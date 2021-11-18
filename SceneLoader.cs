using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
	int x = 5;
	int y = 6;
	public void LoadNextScene() //Next Scene
	{
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentSceneIndex + 1);
	}
	public void LoadPrevScene() //Previous Scene
    {
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentSceneIndex - 1);
	}
	public void LoadStartScene() //Start
    {
		SceneManager.LoadScene(0);
    }
	public void LoadWinScene() //Win
    {
		SceneManager.LoadScene(x);
    }
	public void LoadLoseScene() //Lose
	{
		SceneManager.LoadScene(y);
	}
	public void QuitGame() //Close Game
    {
		Application.Quit();
    }
}
