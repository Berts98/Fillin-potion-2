using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionMovement : MonoBehaviour
{

    public Transform TpLoc;
    public float speed;

    // Use this for initialization
    void Start()
    {
        //Debug.Log(TpLoc.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Respawntrigger")
        {
            transform.position = new Vector3(TpLoc.transform.position.x, TpLoc.transform.position.y, TpLoc.transform.position.z);
        }
        //Debug.Log(TpLoc.transform.position);
    }



}
