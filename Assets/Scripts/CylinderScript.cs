using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : MonoBehaviour
{
    public string PlayerName = "CylinderPlayer";
    public int Healt = 100;
    public Vector3 Location = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
