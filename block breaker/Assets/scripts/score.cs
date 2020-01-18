using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    [SerializeField] int points;
    [SerializeField] Text scoretext;
 
    
    void Awake()
    {
        int count = FindObjectsOfType<score>().Length;
        if(count>1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    
    void Start()
    {
        scoretext = FindObjectOfType<Text>();
        scoretext.text = points.ToString();
    }


    public void addscore()
    {
        points = points + 10;
        scoretext.text = points.ToString();
    }

    public void reset()
    {
        Destroy(gameObject);
    }

}
