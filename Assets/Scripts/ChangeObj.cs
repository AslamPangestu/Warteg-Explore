using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObj : MonoBehaviour {

    ObjectTypeFood foodType;
    public GameObject[] objChange;
    //Makanan makan;
    Customer pelanggan;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
/*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Makanan")
        {
            Debug.Log("Makanan");
            if(foodType == ObjectTypeFood.Ayam)
            {
                Debug.Log("Ayam");
            Instantiate(objChange[0], transform.position, transform.rotation);

            }
            /*Debug.Log("Makanan");
            if(makan.foodType == ObjectTypeFood.Ayam)
            {
                Instantiate(objChange[0], transform.position, transform.rotation);
                
                
            }
            else if (makan.foodType == ObjectTypeFood.Tempe)
            {
                Instantiate(objChange[1], transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
        else if (gameObject.CompareTag("Combine"))
        {
            if(collision.gameObject.tag == "Makanan")
            {
                Instantiate(objChange[2], transform.position, transform.rotation);
            }else if (collision.gameObject.tag == "Pelanggan")
            {
                //jika pelanggan 1 bertemu tempenasi maka destroy pelanggan dan makanan + rep + uang
                //jika pelanggan 2 bertemu ayamnasi 
                //jika pelanggan 3 bertemu tempeayamnasi
            }
        }
            //tambah reputasi
    }*/
}
