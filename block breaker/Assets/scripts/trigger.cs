using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger : MonoBehaviour
{
 

    int reset = 0;
    private void OnTriggerEnter2D(Collider2D collision)
   {
        //int currentIndex=SceneManager.GetActiveScene().buildIndex

        
        SceneManager.LoadScene("win");
        
   }
}
