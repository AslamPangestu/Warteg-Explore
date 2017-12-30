using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customer : MonoBehaviour {

    public string[] tagCollection;
    public Sprite[] sprites;
    public SpriteRenderer image;

    // Use this for initialization
    void Start () {
        gameObject.tag = tagCollection[Random.Range(0, tagCollection.Length)];
        print(gameObject.tag);
        GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
