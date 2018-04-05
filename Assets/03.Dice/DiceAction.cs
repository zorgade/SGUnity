using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiceAction : MonoBehaviour {

    public static int value = 3;
    private float timer = 2f;
    public string sceneName;
    

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0.0f)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    /*Vector3[] faces = { Vector3.up, Vector3.right, Vector3.forward, -Vector3.forward, -Vector3.right, -Vector3.up };
    bool rolling = false;
    public Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        if (rolling && rb.velocity.magnitude < 0.001f)
        {
            rolling = false;
            int i = WhichSide();
            if (i == -1)
            {
                Debug.Log("At an angle");
            }
            else
            {
                Debug.Log("Displaying value " + i);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
        }
    }

    public void RollDice()
    {
        rolling = true;
        Vector3 force = Vector3.forward * Random.Range(400.0f, 600.0f) + Vector3.up * Random.Range(200.0f, 250.0f) + Vector3.right * Random.Range(-50.0f, 50.0f);
        rb.AddForce(force);

        Vector3 v = Vector3.forward;
        v = Random.rotation * v;
        rb.AddTorque(v * 25.0f);
    }

    int WhichSide()
    {
        for (int i = 0; i < faces.Length; i++)
        {
            if (Vector3.Dot(Vector3.up, transform.TransformDirection(faces[i])) > 0.8f)
            {
                return i + 1;
            }
        }
        return -1;
    }*/
}