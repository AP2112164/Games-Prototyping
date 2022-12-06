using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContact : MonoBehaviour
{
    private int hits = 0;
    public AudioSource death;
    ParticleSystem archerBlood;
    // Start is called before the first frame update
    void Start()
    {
        archerBlood = GameObject.Find("blood").GetComponent<ParticleSystem>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            hits++;
            archerBlood.Play();
            Destroy(collision.gameObject);

            if(hits == 3)
            {
                Destroy(this.gameObject);
                death.Play();
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
        
    //}
}
