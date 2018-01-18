using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectTypeFood
{
    Tempe,
    Ayam,
    NasiTempe,
    NasiAyam,
    Lengkap
}
public class Makanan : MonoBehaviour {

    public ObjectTypeCustomer typeCustomer;
    public ObjectTypeFood foodType;
    public GameObject[] objChange;
    private Vector3 screenPoint;
    private Vector3 offset;
    private float firstY;
    private float firstX;
    private GameObject makanan;
    public GameObject baseFood;
    public GameObject pemesanan;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if (gameObject.CompareTag("Makanan"))
        {
            makanan = Instantiate(gameObject, transform.position, transform.rotation);
        }
        firstY = transform.position.y;
        firstX = transform.position.x;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
    
    private void OnMouseUp()
    {
        transform.position = new Vector3(firstX, firstY, transform.position.z);
        Destroy(makanan);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Base")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (foodType == ObjectTypeFood.Ayam)
            {
                Instantiate(objChange[0], transform.position, transform.rotation);
            }
            else if (foodType == ObjectTypeFood.Tempe)
            {
                Instantiate(objChange[0], transform.position, transform.rotation);
            }
        }else if(collision.gameObject.tag == "Combine")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Instantiate(objChange[1], transform.position, transform.rotation);
        }

        switch (typeCustomer)
        {
            case ObjectTypeCustomer.Customer1:
                {                   
                    if (foodType == ObjectTypeFood.NasiAyam)
                    {
                        Destroy(collision.gameObject);
                        Destroy(gameObject);
                    }
                    break;

                }

            case ObjectTypeCustomer.Customer2:
                {
                    if (foodType == ObjectTypeFood.NasiTempe)
                    {
                        Destroy(collision.gameObject);
                        Destroy(gameObject);
                    }
                    break;
                }

            case ObjectTypeCustomer.Customer3:
                {
                    if (foodType == ObjectTypeFood.Lengkap)
                    {
                        Destroy(collision.gameObject);
                        Destroy(gameObject);
                    }
                    break;
                }
        }
    }
}
