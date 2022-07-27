using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp = 5;
    public int attack = 2;
    public int recover = 1;
    public string namePlayer = "Player1";
    public float speed = 2f;
    public Vector3 dir;

    void Start()
    {
        Debug.Log(hp);
        Debug.Log("EJECUTANDO EL STAR");
        Damage(attack);
        Life(recover);
    }

    // Update is called once per frame

    void Update()
    {
        //Damage();
        //Life();
        Debug.Log("EJECUTANDO EL UPDATE");
        transform.position += dir * speed * Time.deltaTime; 
    }

    void Damage(int attackValue)
    {
        hp = hp - attackValue;
    }

    void Life(int lifeValue)
    {
        hp = hp + lifeValue;
    }
    
    public void MovePlayer(Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}

