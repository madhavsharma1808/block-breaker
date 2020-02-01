using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloading : MonoBehaviour

{
   
    public void loadnextscene()
	{
		int currentindex=SceneManager.GetActiveScene().buildIndex;    //This calls the class SceneManager and then get the index of the current active scene
		SceneManager.LoadScene(currentindex+1);
	}

	public void playagain()
	{
        SceneManager.LoadScene(0);
        FindObjectOfType<score>().reset();
        
		
	}

	public void QuitGame()
	{
		Application.Quit();  //will quite the gameplay
	}

}