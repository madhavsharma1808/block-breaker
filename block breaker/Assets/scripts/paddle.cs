using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    [SerializeField] float screenwidth;
	[SerializeField] float min;
	[SerializeField] float max;

    // Update is called once per frame
    void Update()
    {
       float mousecursor=Input.mousePosition.x*screenwidth/Screen.width;
	   float absolute=Mathf.Clamp(mousecursor,min,max);
	   Vector2 paddlepos=new Vector2(absolute,transform.position.y);
	   transform.position=paddlepos;
    }
}
