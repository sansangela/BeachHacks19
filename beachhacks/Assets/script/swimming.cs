using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class swimming : MonoBehaviour {

    public GameObject pillar_pair_prefab;
    public GameObject skill;
    public GameObject progress1;
    public GameObject progress2;
    public GameObject progress3;
    public GameObject end;
    public Sprite up;
    public Sprite down;
    public Sprite nomove;
    private int time = 0;

   

    // Use this for initialization
    Rigidbody2D rb;
    public float flap_force = 100;

    private int skillenergy=300;

    public static bool isDead = false;
    
    public static int value = 0;
    public static bool isSnap = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 20 == 0)
        {
            if (GetComponent<SpriteRenderer>().sprite == up)
            {
                GetComponent<SpriteRenderer>().sprite = down;


            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = up;
            }
        }
        if (isDead == false)
        {
            if (time>=600)
            {
                progress1.SetActive(true);
            }else
            {
                progress1.SetActive(false);
            }
            if (time >= 1200)
            {
                progress2.SetActive(true);
            }
            else
            {
                progress2.SetActive(false);
            }
            if (time >= 1800)
            {
                progress3.SetActive(true);
                end.SetActive(true);
            }
            else
            {
                progress3.SetActive(false);
            }
            if (value == 0)
            {
                rb.velocity = Vector2.zero;
                //GetComponent<SpriteRenderer>().sprite = nomove;
                // print("unchanged");
            }
            if (value == 1)
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * flap_force);
               // GetComponent<SpriteRenderer>().sprite = up;
                // print("upward");    
            }
            if (value == -1)
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.down * flap_force);
              //  GetComponent<SpriteRenderer>().sprite = down;
                // print("downward");
            }
            skillenergy = skillenergy+Time.frameCount / 1000;
           
            if (skillenergy >= 300)
            { skill.SetActive(true); }
            else {
                skill.SetActive(false);
            }

            if (isSnap && (skillenergy>=270))
            {
                skillenergy = 0;
                int i = Time.frameCount;
                
                print("11");
                GetComponent<SpriteRenderer>().sprite = nomove;
                gameObject.layer = 11;
                Invoke("TEST",3f);

              







                


            }

           
               

            
        }

        if (isDead == true && Input.GetKeyDown(KeyCode.Space))
        {
            //score.mytext.text = "";
            //score.time = 0;
            SceneManager.LoadScene("Capsule Hands (Desktop)");
            isDead = false;
            pillar_pair_prefab.SetActive(false);


            time = 0;
           
           
            
        }
        time=time+1;
       // print(time);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Zero out the bird's velocity
        rb.velocity = Vector2.zero;
        // If the bird collides with something set it to dead...
        isDead = true;
        //...tell the Animator about it...
        pillar_pair_prefab.SetActive(true);

        
        StartCoroutine(Delay());




    }
    
    IEnumerator Delay()
    {

        yield return new WaitForSeconds(2.00f);

        


    }
    void TEST ()
    {
        gameObject.layer = 0;
        print("0");
    }
}


