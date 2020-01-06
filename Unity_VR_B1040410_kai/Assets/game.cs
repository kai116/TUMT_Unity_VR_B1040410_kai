using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour {
    public bool shot=false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void freeze()
    {
        if (shot == true)
        {
            this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            shot = false;
        }
    }
    public void TOyz()
    {
        this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "標靶")
        {
            shot = true;
        }
    }
}
