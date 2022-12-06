using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GemScore : MonoBehaviour
{
    public TextMeshProUGUI myScoreText;
    private int scoreNumber;
    private int spawnShine;
    public AudioSource collected;
    ParticleSystem orbPart;
    // Start is called before the first frame update
    void Start()
    {
        scoreNumber = 0;
        spawnShine = 60;
        myScoreText.text = "Gems : " + scoreNumber;
        orbPart = GameObject.Find("shine").GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "blueGem")
        {
            scoreNumber += 10;
            Destroy(collision.gameObject);
            myScoreText.text = "Gems : " + scoreNumber;
            collected.Play();
        }

        if (collision.gameObject.tag == "redGem")
        {
            scoreNumber += 5;
            Destroy(collision.gameObject);
            myScoreText.text = "Gems : " + scoreNumber;
            collected.Play();
        }

        if (collision.gameObject.tag == "orb")
        {
            scoreNumber += 80;
            Destroy(collision.gameObject);
            myScoreText.text = "Gems : " + scoreNumber;
            collected.Play();
            orbPart.Stop();
        }

        if(scoreNumber >= spawnShine)
        {
            orbPart.Play();
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
