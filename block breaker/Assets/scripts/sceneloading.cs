using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloading : MonoBehaviour

{
    score score;
    public void loadnextscene()
	{
		int currentindex=SceneManager.GetActiveScene().buildIndex;    //This calls the class SceneManager and then get the index of the current active scene
		SceneManager.LoadScene(currentindex+1);
	}

	public void playagain()
	{
        score = FindObjectOfType<score>();
        score.reset();
		SceneManager.LoadScene(0);
	}

	public void QuitGame()
	{
		Application.Quit();  //will quite the gameplay
	}

}