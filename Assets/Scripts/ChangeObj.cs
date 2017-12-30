using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObj : MonoBehaviour {

    public string nameTag;
    public GameObject objChange;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            objChange = Instantiate(objChange, transform.position, transform.rotation);
            //tambah reputasi
        }
    }
}
