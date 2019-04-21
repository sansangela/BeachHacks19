using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {

  public Sprite closeeye;
  public Sprite openeye;
  public float movemnet_speed = 0.02f;
    // Use this for initialization
    void Start()
    {



  

}

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 30 == 0)
        {
            if (GetComponent<SpriteRenderer>().sprite == openeye)
            {
                GetComponent<SpriteRenderer>().sprite = closeeye;


            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = openeye;
            }
        }
        if (swimming.isDead == false)
        {
            transform.Translate(Vector2.left * movemnet_speed);
        }
    }
}

