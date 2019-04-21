using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jellyfish : MonoBehaviour {


    public Sprite closeeye;
    public Sprite openeye;
    public float movemnet_speed = 0.02f;
    public float integral;


    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.left * movemnet_speed);
       // transform.Translate(Vector2.down * (Mathf.Sin(Time.time) / integral));

        if (Time.frameCount % 10 == 0)
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
            transform.Translate(Vector2.down * (Mathf.Sin(Time.time) / integral));
        }
       
        if (transform.position.x < -10)
        {
            RepositionBackground();
        }
    }
    private void RepositionBackground()
    {
        Vector2 groundoffSet = new Vector2(10 * 2f, 0);
        transform.position = (Vector2)transform.position + groundoffSet;
    }
}



