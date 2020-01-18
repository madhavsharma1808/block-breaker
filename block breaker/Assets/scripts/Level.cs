using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int blocks;
 
    

	public void countblocks()
    { 
         blocks++;
    }
	
	public void decrementblock()
	{
	blocks--;
       
    
    if (blocks==0)
	{
            int currentsceneindex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentsceneindex+1 );
	}

    
	
	}
}
