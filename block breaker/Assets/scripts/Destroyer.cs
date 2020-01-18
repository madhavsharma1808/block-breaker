using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
	[SerializeField] AudioClip myaudio;
    [SerializeField] GameObject sparkle;
    Level level;
    score score;
	
	void Start()
	{
		level=FindObjectOfType<Level>();
        score = FindObjectOfType<score>();
        level.countblocks();
	}
	
	
  private void OnCollisionEnter2D(Collision2D collision)
  {
		
	
  	  Destroy(gameObject);
      effect();
	  AudioSource.PlayClipAtPoint(myaudio,new Vector2(5, 1));
	  level.decrementblock();
       score.addscore();
  }

    public void effect()
    {
        GameObject sparkles = Instantiate(sparkle, transform.position, transform.rotation);
        Destroy(sparkles,1f);
    }
}
