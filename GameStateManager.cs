using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameObject prefab;
    public int howMany;

    // Use this for initialization
    void Start()
    {
        GameObject tmpAsteroid;
        AsteroidMove am;

        for (int i = 0; i < howMany; i++)
        {
            tmpAsteroid = Instantiate(
                prefab,
                new Vector3(Random.Range(-12, 12), Random.Range(-4, 4), 0),
                Quaternion.identity
             );

            am = tmpAsteroid.GetComponent<AsteroidMove>();

            am.mx = Random.Range(-5, 5);
            am.my = Random.Range(-5, 5);
            am.rotz = Random.Range(-5, 5);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
