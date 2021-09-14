using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tree : MonoBehaviour
{
    // Start is called before the first frame update
    bool movingLeft = true;
    public float speed = 5f;
    Vector2 currentPos; 
    public GameObject apple;
    public float maxTime = 5;
    public float minTime = 2;
    private float time;
    private float spawnTime = 2;
   

  
    void Start()
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
        time = minTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if(time >= spawnTime){
             DropApple();
             SetRandomTime();
         }
        if(movingLeft){
            transform.position = new Vector2(transform.position.x + (-1 * speed * Time.deltaTime),transform.position.y);
            if (transform.position.x < -10)
                movingLeft = false;
        } else {
            transform.position = new Vector2(transform.position.x + (1 * speed * Time.deltaTime),transform.position.y);
            if(transform.position.x > 10)
                movingLeft = true;
        }
    }
    void SetRandomTime(){
         spawnTime = Random.Range(minTime, maxTime);
     }

    void DropApple(){
        time = 0;
        Instantiate(apple, transform.position,apple.transform.rotation);
    }


 
    
}
