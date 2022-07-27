using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala: MonoBehaviour
{
    // Start is called before the first frame update
    public int attack = 2;
    public float speed = 2f;
    public Vector3 dir;

    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime; 
    }

    public void MovePlayer(Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
