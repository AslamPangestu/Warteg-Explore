using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCust : MonoBehaviour {

    public static SpawnCust Instance;

    public GameObject[] objCust;// menyimpan objek yg akan di inistiante
    public SpawnUser[] spawnPoint;//array untuk menyimpan spawn location
    GameObject pelanggan;

    public GameObject[] think;
    public Transform[] spawnThink;
    GameObject pemesanan;

    public Transform basePos;
    public GameObject baseFood;

    private void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start () {

        StartCoroutine(Spawning());
	}

    IEnumerator Spawning()
    {
        yield return new WaitForSeconds(Random.Range(2.5f, 5f));
        int randSpawn = Random.Range(0, spawnPoint.Length);//menentukan index object spawn poin
        int randCust = Random.Range(0, objCust.Length);//menentukan index object pelanggan

        if (spawnPoint[randSpawn].user == null)
        {
            pelanggan = Instantiate(objCust[randCust], spawnPoint[randSpawn].transform);
            spawnPoint[randSpawn].user = pelanggan;
            pelanggan.GetComponent<Customer>().RandomPesanan();
            if (pelanggan.GetComponent<Customer>().customerType == ObjectTypeCustomer.Customer1)
            {
                pemesanan = Instantiate(think[0], spawnThink[randSpawn]);
            }
            else if (pelanggan.GetComponent<Customer>().customerType == ObjectTypeCustomer.Customer2)
            {
                pemesanan = Instantiate(think[1], spawnThink[randSpawn]);
            }
            else if (pelanggan.GetComponent<Customer>().customerType == ObjectTypeCustomer.Customer3)
            {
                pemesanan = Instantiate(think[2], spawnThink[randSpawn]);
            }
            else if (pelanggan.GetComponent<Customer>().customerType == ObjectTypeCustomer.Customer4)
            {
                pemesanan = Instantiate(think[3], spawnThink[randSpawn]);
            }
            else if (pelanggan.GetComponent<Customer>().customerType == ObjectTypeCustomer.Customer5)
            {
                pemesanan = Instantiate(think[4], spawnThink[randSpawn]);
            }
            else if (pelanggan.GetComponent<Customer>().customerType == ObjectTypeCustomer.Customer6)
            {
                pemesanan = Instantiate(think[5], spawnThink[randSpawn]);
            }
            else if (pelanggan.GetComponent<Customer>().customerType == ObjectTypeCustomer.Customer7)
            {
                pemesanan = Instantiate(think[6], spawnThink[randSpawn]);
            }
            pemesanan.transform.parent = pelanggan.transform;
        }
        StartCoroutine(Spawning());
    }

    public void BaseFood()
    {
        Instantiate(baseFood, basePos);
    }
}
