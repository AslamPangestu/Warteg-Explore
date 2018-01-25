using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempatSampah : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Combine" || collision.gameObject.tag == "Combine1" || collision.gameObject.tag == "Full")
        {
            Destroy(collision.gameObject);
            SpawnCust.Instance.BaseFood();
            ScoresManager.Instance.DecCoin();
        }
    }
}
