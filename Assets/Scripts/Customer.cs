using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectTypeCustomer
{
    Customer1,
    Customer2,
    Customer3,
    Customer4,
    Customer5,
    Customer6,
    Customer7
}
public class Customer : MonoBehaviour {

    public ObjectTypeCustomer customerType;
    public AudioSource audioSource;
    public AudioClip audioClip;

    public static Customer Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void RandomPesanan()
    {
        customerType = (ObjectTypeCustomer)Random.Range(0, 7);
        Debug.Log(customerType);
    }


}
