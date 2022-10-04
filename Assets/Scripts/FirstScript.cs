using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FirstScript : MonoBehaviour
{

    [SerializeField] string PlayerName = "Player1";
    public bool degisken = true;
    public float Position = 1f;
    public float Position2 = 0.3f;
    [SerializeField] int Healt = 100;
    // x y z
    public Vector3 Location = new Vector3(0, 0, 0);
    //   x y
    public Vector2 Location2D = new Vector2(0, 0);

    [SerializeField] SphereScript sphereScript;
    [SerializeField] CylinderScript cylinderScript;

    [SerializeField] GameObject Sphere;
    [SerializeField] GameObject Cylinder;

    [SerializeField] Color color;
    Renderer r;

    [SerializeField] List<GameObject> GameObjectList;
    [SerializeField] GameObject[] GameObjectArray;
    // İlk çalışır. Play butonuna bastıkltan sonra çalışır. Ilk frame den önce çalışır.
    private void Awake()
    {
        // degisken = false;
        // Debug.Log("Oyun ayağı kalktı");
        Array.Resize(ref GameObjectArray, 10);
    }
    // Playe tıkladığından çalışır. Script her aktif olduğunda çalışır. Awake den sonra ve Starttan önce çalışır.
    private void OnEnable()
    {
        // Debug.Log("Script Aktif");
    }
    // Playe tıkladığında çalışır. Oyun ayağı kalktıktan sonraki ilk frame de çalışır.
    void Start()
    {


        // Debug.Log("Test Mesajı, Oyun Başladı");

        // Debug.Log("Player Name : " + PlayerName);
        // Debug.Log("Bool Degisken : " + degisken);
        // Debug.Log("Position1 : " + Position);
        // Debug.Log("Position2 : " + Position2);
        // Debug.Log("Player Healt : " + Healt);
        // Debug.Log("Location : " + Location);
        // Debug.Log("Location 2D : " + Location2D);

        //Sphere.active = false;

        // Objeyi açıp kapatmak için kullanıyoruz.
        //Sphere.SetActive(false);

        // Scripti Açıp kapatır
        //sphereScript.enabled = false;

        //Çok kaynak tüketir. String ile hierarchyde sorgulama yaparak gameobjeyi bulur.
        Sphere = GameObject.Find("Sphere");
        Cylinder = GameObject.Find("Cylinder");

        Sphere = GameObject.FindObjectOfType<SphereScript>().gameObject;
        Cylinder = GameObject.FindObjectOfType<CylinderScript>().gameObject;

        foreach (var item in GameObject.FindObjectsOfType<SphereScript>())
        {
            GameObjectList.Add(item.gameObject);
            if (item.gameObject.name == "Sphere")
            {
                item.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
        }





        // Sphere GameObjesine ulaşıp içinden SphereScript componentine erişiyoruz
        sphereScript = Sphere.GetComponent<SphereScript>();
        // Cylinder GameObjesine ulaşıp içinden CylinderScript componentine erişiyoruz
        cylinderScript = Cylinder.GetComponent<CylinderScript>();

        r = GetComponent<Renderer>();

        // this.gameObject.GetComponent<BoxCollider>(); == GetComponent<BoxCollider>(); == this.GetComponent<GameObject>();

        Debug.Log("Sphere : " + sphereScript.PlayerName + " Healt : " + sphereScript.Healt);
        Debug.Log("Cylinder : " + cylinderScript.PlayerName + " Healt : " + cylinderScript.Healt);

        Debug.Log(gameObject.name);
        gameObject.AddComponent<Rigidbody>();
        // gameObject = script hangi objenin içindeyse bulunduğu gameObject;



    }
    // Playe tıkladığından çalışır. Script her deaktif olduğunda çalışır.
    private void OnDisable()
    {
        //Debug.Log("Script kapalı");
    }


    //Script her açıldığında aktif olduğunda çalışır.

    // Script her kapandığında çalışır





    // private void FixedUpdate()
    // {
    //     Debug.Log("Fixed Update");
    // }
    void Update()
    {
        // Debug.Log("Update");
        r.material.color = color;
    }
    // private void LateUpdate()
    // {
    //     Debug.Log("Late Update");
    // }
}
