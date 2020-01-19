using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listener : MonoBehaviour
{

    
    private void OnCollisionEnter2D(Collision2D Collision)
	{
		GetComponent<AudioSource>().Play();
	}
}
