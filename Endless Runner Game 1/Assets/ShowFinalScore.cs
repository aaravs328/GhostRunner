using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFinalScore : MonoBehaviour {

    public Text FinalScore;

	// Use this for initialization
	void Start () {
        FinalScore.text = GameController.control.score.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
