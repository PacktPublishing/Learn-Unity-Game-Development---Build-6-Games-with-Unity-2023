using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed;
 
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPos = Input.mousePosition;
            touchPos = Camera.main.ScreenToWorldPoint(touchPos);

            if(touchPos.x < 0)
            {
                // transform.position += Vector3.left * speed * Time.deltaTime; 
                rb.AddForce(Vector2.left * speed);

            }
            else
            {
                // transform.position += Vector3.right * speed * Time.deltaTime;
                rb.AddForce(Vector2.right * speed );
            }


        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Block")
        {
            SceneManager.LoadScene("Game");
        }
    }


}
