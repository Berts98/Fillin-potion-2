using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bottle : MonoBehaviour {

    public Sprite emptyImage;
    public Sprite fillImage;
    public float speed;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        
    }

   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "destroy")
        {
            Destroy(gameObject);
        }
       
    }


}
