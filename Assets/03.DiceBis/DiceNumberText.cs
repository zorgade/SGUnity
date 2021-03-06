﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DiceNumberText : MonoBehaviour {

    Text text;
    public Button btn;

    public static int diceNumber;
    public string sceneName;
    //public Button btn;
    // Use this for initialization
    private void Awake()
    {
        text = GetComponent<Text>();
        text.enabled = false;
        btn.gameObject.SetActive(false);

    }
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        text.text = diceNumber.ToString();
        if (diceNumber > 0)
        {
            text.enabled = true;
            btn.gameObject.SetActive(true);
        }
        Debug.Log(text.text);
	}
    public void OnClick(string sceneName)
    {
        
            SceneManager.LoadScene(sceneName);
        
    }
}
