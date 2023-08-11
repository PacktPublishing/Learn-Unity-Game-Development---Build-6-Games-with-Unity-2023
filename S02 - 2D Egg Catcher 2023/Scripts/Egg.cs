using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{

    public float breakPoint = -6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.y < breakPoint)
        {

            GameManager.instance.GameOver();
            //Destroy(gameObject);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "InsideBasket")
        {
            //increase score
            GameManager.instance.AddScore();

            Destroy(gameObject);

        }

    }


}
