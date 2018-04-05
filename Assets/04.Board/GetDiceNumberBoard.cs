using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetDiceNumberBoard : MonoBehaviour {

    Text txt;
    Button btn;
	// Use this for initialization
	void Start () {
        txt = GetComponent<Text>();
        txt.text = DiceNumberText.diceNumber.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
