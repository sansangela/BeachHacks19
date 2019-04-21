using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sky : MonoBehaviour {




    public float movemnet_speed = 0.008f;
    private BoxCollider2D skycollider;
    private float skyhorizontallength;
    // Use this for initialization
    void Start()
    {
        skycollider = GetComponent<BoxCollider2D>();
        skyhorizontallength = skycollider.size.x;
    }

    // Update is called once per frame
    private void Update()
    {
        if (swimming.isDead == false)
        {
            transform.Translate(Vector2.left * movemnet_speed);
        }
        if (transform.position.x < -skyhorizontallength)
        {
            RepositionBackground();
        }
    }
    private void RepositionBackground()
    {
        Vector2 groundoffSet = new Vector2(skyhorizontallength * 1.9f, 0);
        transform.position = (Vector2)transform.position + groundoffSet;
    }
}
    



