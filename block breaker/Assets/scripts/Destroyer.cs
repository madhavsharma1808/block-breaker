using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
	[SerializeField] AudioClip myaudio;
    [SerializeField] GameObject sparkle;
    Level level;
    score score;
    [SerializeField] int maxhits;
    [SerializeField]int hits = 0;
	void Start()
	{
		level=FindObjectOfType<Level>();
        score = FindObjectOfType<score>();
        if(tag=="breakable")
        {
            level.countblocks();
        }
            
       
	}
	
	
  private void OnCollisionEnter2D(Collision2D collision)
  {
        
	  if(tag=="breakable"&& hits>=maxhits)
        {
            hits++;
            Destroy(gameObject);
            level.decrementblock();
        }
  	 
      effect();
	  AudioSource.PlayClipAtPoint(myaudio,new Vector2(5, 1));
        if (tag == "breakable")
        {
            
            score.addscore();
        }
  }

    public void effect()
    {
        GameObject sparkles = Instantiate(sparkle, transform.position, transform.rotation);
        Destroy(sparkles,1f);
    }
}
