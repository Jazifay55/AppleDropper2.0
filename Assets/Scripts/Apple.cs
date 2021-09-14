using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    // Start is called before the first frame update
    public int count = 0;
    public bool dropped = false;
 
  void OnCollisionEnter2D(Collision2D collision)
     {
         if(caught(collision))
            Delete();
         if(Dropped(collision))
            dropped = true;
     }
  bool caught(Collision2D collision)
    {
        Basket basket = collision.gameObject.GetComponent<Basket>();
        if(basket != null)
            return true;
        
        return false;
    }

    void Delete()
    {
        gameObject.SetActive(false);
    }
    public bool droppedApple()
    {
        return dropped;
    }

    bool Dropped(Collision2D collision)
    {
        Square square = collision.gameObject.GetComponent<Square>();
        if(square != null){
            return true;
        }
        return false;
    }
  




}
