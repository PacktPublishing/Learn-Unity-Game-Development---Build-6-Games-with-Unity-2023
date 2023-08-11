using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{

    Vector3 touchPos;
    public float moveRate = 0.2f;
    public float limitX;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            touchPos = Camera.main.ScreenToWorldPoint ( Input.mousePosition ) ;

            Vector3 newPos = transform.position;
            newPos.x = touchPos.x;

            //limit the position
            newPos.x = Mathf.Clamp(newPos.x, -limitX, limitX);


            transform.position = Vector3.Lerp(transform.position, newPos, moveRate);


        }



    }
}
