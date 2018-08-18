using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //Chave necessaria para passar de fase
    public bool key;
    //corpo do personagem
    private Rigidbody2D rigid;
    //tamanho do passo
    public float step;
    //guarda as lanternas
    public GameObject lanterna, lanterna2;

    // Use this for initialization
    void Start ()
    {
        key = false;
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update ()
    {
        move();
    }

    void move()
    {
        float x = 0;
        float y = 0;

        if (Input.GetButtonDown("right"))
        {
            x = step;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetButtonDown("left"))
        {
            x = -step;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetButtonDown("up")) y = step;           
        if (Input.GetButtonDown("down")) y = -step;
        
        Vector2 movimento = new Vector2(x,y);
 
        if (movimento != Vector2.zero) rigid.MovePosition(rigid.position + movimento * Time.deltaTime);
        //transform.Translate(Vector2.right * step * Time.deltaTime)
    }

}
