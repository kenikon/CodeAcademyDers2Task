using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    public string PlayerName = "NewSphere";
    public int Healt = 150;
    public Vector3 Location = new Vector3(0, 0, 0);

    [SerializeField] CubeManager cubeManager;
    [SerializeField] GameObject Cube;

    void Start()
    {
        cubeManager = Cube.GetComponent<CubeManager>();

        Debug.Log("Cube :" + cubeManager.PlayerName + " Healt :" + cubeManager.Healt);
        Cube.GetComponent<Renderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
