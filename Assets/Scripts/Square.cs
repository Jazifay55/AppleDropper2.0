using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square : MonoBehaviour
{
    // Start is called before the first frame update
    private List<GameObject> baskets; 
    public GameObject basketFab;
    public int score = 0;
    public Text mytext;
    void Start()
    {
        baskets = new List<GameObject>();
        float bot = -4 + 0.5f;
        for(int i = 0; i < 3; i++){
            GameObject basket = Instantiate<GameObject>(basketFab);
            Vector3 pos = basket.transform.position;
            pos.y = bot + (i * 1f);
            basket.transform.position = pos;
            baskets.Add(basket);
        }
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "apple"){
            int top = baskets.Count -1;

            if(top > -1){
                Destroy(baskets[top]);
                baskets.RemoveAt(top);
            }
            if(top <= 0)
                Debug.Log("Game Over!!!");
        }
    }

      public void checkScore()
    {
        score = score + 1;
        GameObject.Find("Score").GetComponent<Text>().text = score.ToString();
    }
    
}
