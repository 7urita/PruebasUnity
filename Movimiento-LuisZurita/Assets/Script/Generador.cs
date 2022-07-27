using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BalaPrefab;
    public float delaySpawn = 2f;
    public float intervalSpawn = 2f;

    void Start()
    {
        Invoke("Disparo", delaySpawn);
        InvokeRepeating("Disparo", delaySpawn, intervalSpawn);
    }

    void Disparo()
{
    Instantiate(BalaPrefab,transform);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
