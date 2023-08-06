using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.1f; // velocidade = 0.1
    public float jumpspeed = 0.5f; //velociade pulo = 0.5
    public Rigidbody2D rigidBody; //cria objeto RigidBody2D

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();// variavel é inicializada quando o jogo começa
    }

    // Update is called once per frame
    void Update(){

        var x = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(x*speed, rigidBody.velocity.y); // todo frame a velocidade do rigidbody= velocidade horizontal, velociade vertical permanece a mesma

        // Entre na condição quando apertar a barra de espaço
        if (Input.GetButton("Jump")) { 

            Debug.Log("Jump"); // Quando pular escreve "Jump" no Debug Log
            rigidBody.velocity += Vector2.up * jumpspeed; // velociade do rigidbody = velocidade vertical*velocidade pulo 
        }

    }
}
