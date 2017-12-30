﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCust : MonoBehaviour {

    private float jeda = 2.5f;// variabel untuk memberi jeda spawn 
    float timer;//variabel counter waktu
    public GameObject objCust;// array utk menyimpan objek

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;//berdasarkan waktu jeda yang telah ditentukan
        if (timer > jeda)
        {
            //int random = Random.Range(0, objCust.Length);//menentukan index object sampah secara acak yang akan dimunculkan
            objCust = Instantiate(objCust, transform.position, transform.rotation); //memunculkan object Sampah dari index yang telah ditentukan sebelumnya dengan posisi dan rotasi Gameoject yang terdapat Script ini
            timer = 0;// timer dikembalikan ke 0 untuk menghitung nilai jeda dari awal
        }
    }
}
