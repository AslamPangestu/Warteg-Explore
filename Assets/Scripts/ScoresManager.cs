using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoresManager : MonoBehaviour {

    public static ScoresManager Instance;

    [Header("Property")]
    public int score;
    public int rep;

    [Header("UI")]
    public Text scoreLabel;
    public int repLabel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
