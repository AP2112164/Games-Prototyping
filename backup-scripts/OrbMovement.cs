using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbMovement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }


    void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, -0.5f));
    }



}


