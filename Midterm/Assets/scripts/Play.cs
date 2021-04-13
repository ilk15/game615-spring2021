using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public paw paw1;
    public GameObject cupPrefab;

    public GameObject coffee;

    public bool play = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
           if (paw1.moveTimer < 0 && play)
            {
                paw1.Attack();
            }
        }


     //   if (coffee.GetComponent<cup>().hold == false )
       //    //play = false;
      //  }
    }

    
    
    public void spawnCup()
    {
       coffee = (GameObject)Instantiate(cupPrefab, transform.position, transform.rotation);
       paw1.Turn();
    }
    

     public void ToggleGame()
    {
        
        play = !play;

    }
}
