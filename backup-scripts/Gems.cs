using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems : MonoBehaviour
{
    public int rotz;
    public int mx, my;
    public Rigidbody2D myRigid;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();

        myRigid.AddForce(Vector3.up * mx);
        myRigid.AddForce(Vector3.right * my);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, rotz)); 
    }
}
