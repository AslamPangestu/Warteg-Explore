using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCust : MonoBehaviour {

    private float jeda = 2.5f;// variabel untuk memberi jeda spawn 
    float timer;//variabel counter waktu
    public GameObject objCust;// menyimpan objek yg akan di inistiante
    public Transform[] spawnPoint;//array untuk menyimpan spawn location

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;//berdasarkan waktu jeda yang telah ditentukan
        if (timer > jeda)
        {
            int random = Random.Range(0, spawnPoint.Length);//menentukan index object sampah secara acak yang akan dimunculkan
            Instantiate(objCust, spawnPoint[random]);
            timer = 0;// timer dikembalikan ke 0 untuk menghitung nilai jeda dari awal
        }
    }
}
