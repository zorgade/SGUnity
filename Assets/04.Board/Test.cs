using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

    public Text txt;
    public static int value;
    public Text score;

    private float timer = 3f;

    private void Awake()
    {
        txt.enabled = true;
        score.enabled = true;
        //score.text = GetComponent<DisplayCurrentDieValue>().currentValue.ToString();
        score.text = "0";
    }
    // Use this for initialization
    void Start () {
        

    }

    // Update is called once per frame
    void Update () {

        timer -= Time.deltaTime;
        if(timer <= 0.0f)
        {
            txt.enabled = false;
            score.enabled = false;
        }
    }
}
