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
    [SerializeField] Sprite[] demote;
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
        
	  if(tag=="breakable")
        {
            hitscheck();
        }

        effect();
	  AudioSource.PlayClipAtPoint(myaudio,new Vector2(5, 1));
        if (tag == "breakable")
        {
            
            score.addscore();
        }
  }

    private void hitscheck()
    {
        hits++;
        if (hits >= maxhits)
        {
            Destroy(gameObject);
            level.decrementblock();
        }
        else
        {
            int spriteindex = hits - 1;
            GetComponent<SpriteRenderer>().sprite = demote[spriteindex];
        }
    }

    public void effect()
    {
        if (tag == "breakable")
        {
            GameObject sparkles = Instantiate(sparkle, transform.position, transform.rotation);
            Destroy(sparkles, 1f);
        }
    }
}
