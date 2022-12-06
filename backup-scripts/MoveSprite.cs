using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSprite : MonoBehaviour
{
    public string left, right;
    public string up, down;
    public string shoot;
    public GameObject bullet;
    public float lastFired;
    public AudioSource shot;
    // Start is called before the first frame update
    void Start()
    {
        lastFired = 0;
    }


    // Update is called once per frame
    void Update()
    {
        GameObject tmpBullet;

        if (Input.GetKey(up))
        {
            this.transform.Translate(new Vector3(0f, 5f, 0f) * Time.deltaTime * 1);
        }
        if (Input.GetKey(left))
        {
            this.transform.Rotate(new Vector3(0f, 0f, 500f) * Time.deltaTime);
        }

        if (Input.GetKey(right))
        {
            this.transform.Rotate(new Vector3(0f, 0f,-500f) * Time.deltaTime);
        }

        if (Input.GetKey(down))
        {
            this.transform.Translate(new Vector3(0f, -5f, 0f) * Time.deltaTime * 1);
        }

        if (Input.GetKey(shoot))
        {
            if (Time.time > lastFired + 1)
            {
                tmpBullet = Instantiate(bullet, this.transform.position + (this.transform.up * 4), this.transform.rotation);
                lastFired = Time.time;
            }
            shot.Play();
        }
    }

}
