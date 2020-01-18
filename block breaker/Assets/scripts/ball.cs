using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
	[SerializeField] paddle paddle1;
	Vector2 difference;
	int flag=0;
	
    // Start is called before the first frame update
    void Start()
    {
        paddle1 = FindObjectOfType<paddle>();
        difference=transform.position-paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {	if(flag==0)
		{
		stick();
		releaseonclick();
		}
    }

	private void stick()
	{
		Vector2 dispaddle=new Vector2(paddle1.transform.position.x,paddle1.transform.position.y);
		transform.position=difference+dispaddle;
	}

	private void releaseonclick()
	{
		if(Input.GetMouseButton(0))
		{
			GetComponent<Rigidbody2D>().velocity= new Vector2(2f,15f);
			flag=1;
			
		}
	}
}
