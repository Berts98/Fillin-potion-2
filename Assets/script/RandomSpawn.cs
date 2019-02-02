using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {


    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5, prefab6, prefab7;
    public float Spawnrate = 2f;
    float NextSpawn = 0f;
    int whatTospawn;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Time.time > NextSpawn)
        {
            whatTospawn = Random.Range(1, 8);                   //random value between 1 and 7 (8 ex)
            switch (whatTospawn)
            {
                case 1:
                    Instantiate(prefab1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(prefab2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(prefab3, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(prefab4, transform.position, Quaternion.identity);
                    break;
              

            }

            NextSpawn = Time.time + Spawnrate;
        }
    }
}
