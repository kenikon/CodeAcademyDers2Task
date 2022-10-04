using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public string PlayerName = "Player2";
    public int Healt = 100;
    public Vector3 Location = new Vector3(0, 0, 0);
    // Start is called before the first frame update

    private void OnDisable()
    {
        Debug.Log("Script Kapandı");
    }
    void Start()
    {
        Debug.Log(gameObject.name);
        Debug.Log("Script Kapanıyor");
        this.enabled = false;
        Debug.Log("Script Kapalı");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Script Çalışıyor");
    }
}
