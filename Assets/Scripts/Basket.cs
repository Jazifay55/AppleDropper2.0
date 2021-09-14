using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 5.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position = new Vector2(transform.position.x + (movement * speed * Time.deltaTime),transform.position.y);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "apple")
            GameObject.Find("Square").GetComponent<Square>().checkScore();
    }





}
