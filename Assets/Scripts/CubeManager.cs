using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public string PlayerName = "NewCube";
    public int Healt = 200;
    public Vector3 Location = new Vector3(1.87f, 0, 0.33f);

    [SerializeField] SphereManager sphereManager;
    [SerializeField] GameObject Sphere;

    void Start()
    {
        sphereManager = Sphere.GetComponent<SphereManager>();

        Debug.Log("Sphere :" + sphereManager.PlayerName + " Healt :" + sphereManager.Healt);
        Sphere.GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
