using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private Rigidbody2D myRigid;
  
    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
  
    }

    // Update is called once per frame
    void Update()
    {
        myRigid.AddForce(this.transform.up * 80);
    }

}
