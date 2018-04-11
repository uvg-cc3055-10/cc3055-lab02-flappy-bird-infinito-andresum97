using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public bool gameOver = false;
    public int score = 0; //Para guardar puntaje del jugador
    public static GameController instance;
	// Use this for initialization
	void Start () {
        instance = this; //Ahora la variable tiene referencia a este objeto
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
