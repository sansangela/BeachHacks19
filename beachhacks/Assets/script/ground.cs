using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour {

    public float movemnet_speed = 0.008f;
    private BoxCollider2D groundCollider;
    private float groundhorizontallength;

    // Use this for initialization
    private void Awake () {
        groundCollider = GetComponent<BoxCollider2D>();
        if(groundCollider == null)
        {
            groundCollider = GetComponentInChildren<BoxCollider2D>();
        }
        groundhorizontallength = groundCollider.size.x;

    }
	
	// Update is called once per frame
	private void Update () {
        if (swimming.isDead == false)
        {
            transform.Translate(Vector2.left * movemnet_speed);
        }
        if (transform.position.x < 0)//-groundhorizontallength)
        {
            RepositionBackground();
        }
    }
    private void RepositionBackground()
    {
        Vector2 groundoffSet = new Vector2(groundhorizontallength*2,0);
        transform.position = (Vector2)transform.position + groundoffSet;
    }
}
