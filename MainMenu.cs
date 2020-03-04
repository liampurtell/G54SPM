using System.Collection;
using System.Collection.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{
	public void PlayGame()
 	{
             SceneManager.LoadScene(SceneManger.GetActiveScene().buildIndex + 1);
	}

	public void QuitGame()
	{
	     Debug.Log("QUIT!");
	     Application.Quit();

}
