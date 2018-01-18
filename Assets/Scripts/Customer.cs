using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ObjectTypeCustomer
{
    Customer1,
    Customer2,
    Customer3
}
public class Customer : MonoBehaviour {

    public ObjectTypeCustomer customerType;
    public ObjectTypeFood foodType;
    Animator anim;
    // public Transform[] spawnThink;//array untuk menyimpan spawn location
    public GameObject[] think;
    public GameObject order;

    // Use this for initialization
    void Start () {
        customerType = (ObjectTypeCustomer)Random.Range(0, 2);
        anim = GetComponent<Animator>();
        Debug.Log(customerType);

        switch (customerType)
        {
            case ObjectTypeCustomer.Customer1:
                {
                    Debug.Log("cus1");
                    order = Instantiate(think[0], new Vector3(transform.position.x + 1.5f, transform.position.y + 3, transform.position.z), transform.rotation);
                    break;
                }

            case ObjectTypeCustomer.Customer2:
                {
                    Debug.Log("cus2");
                    order = Instantiate(think[1], new Vector3(transform.position.x + 1.5f, transform.position.y + 3, transform.position.z), transform.rotation);
                    break;
                }

            case ObjectTypeCustomer.Customer3:
                {
                    Debug.Log("cus3");
                    order = Instantiate(think[2], new Vector3(transform.position.x + 1.5f, transform.position.y + 3, transform.position.z), transform.rotation);
                    break;
                }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
