using UnityEngine;
using System.Collections;

public class DisplayCurrentDieValue : MonoBehaviour
{
	public LayerMask dieValueColliderLayer = -1;

	public int currentValue = 1;

	private bool rollComplete = false;
    public string buttonName = "Fire1";
    public float forceAmount = 10.0f;
    public float torqueAmount = 10.0f;
    public ForceMode forceMode;

    // Update is called once per frame
    void Update ()
	{
		RaycastHit hit;

		if(Physics.Raycast(transform.position,Vector3.up,out hit,Mathf.Infinity,dieValueColliderLayer))
		{
			currentValue = hit.collider.GetComponent<DieValue>().value;
		}

		if(GetComponent<Rigidbody>().IsSleeping() && !rollComplete)
		{
			rollComplete = true;
			Debug.Log("Die roll complete, die is at rest");
		}
		else if(!GetComponent<Rigidbody>().IsSleeping())
		{
			rollComplete = false;
		}
	}
    private void OnGUI()
    {
        GUILayout.Label(currentValue.ToString());

        if (GUI.Button(new Rect(30, 70, 50, 30), "Lancer"))
        {
            GetComponent<Rigidbody>().AddForce(Random.onUnitSphere * forceAmount, forceMode);
            GetComponent<Rigidbody>().AddTorque(Random.onUnitSphere * torqueAmount, forceMode);
        }

    }
}
