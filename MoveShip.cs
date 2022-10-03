using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour {
    public string up;
    public string left, right;
    Rigidbody2D myRigid;
    GameObject myPart;
    ParticleSystem ps;

	// Use this for initialization
	void Start () {
        myRigid = this.GetComponent<Rigidbody2D>();
        myPart = GameObject.Find("Engine");

        ps = myPart.GetComponent<ParticleSystem>();
	}

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0, 0, 0);

        if (Input.GetKey(up))
        {
            myRigid.AddForce(this.transform.up * 10);
            ps.Play();
        }
        else
        {
            ps.Stop();

        }

        if (Input.GetKey(left))
        {
            move = new Vector3(0, 0, 50 * Time.deltaTime);
            this.transform.Rotate(move);
        }

        if (Input.GetKey(right))
        {
            move = new Vector3(0, 0, -50 * Time.deltaTime);
            this.transform.Rotate(move);
        }

    }

}
