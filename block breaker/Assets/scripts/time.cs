using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour
{	[SerializeField] float timevar;
  
    // Start is called before the first frame update
    
   
    
    
    void Start()
    {
        Time.timeScale=timevar;
    }

   
}
