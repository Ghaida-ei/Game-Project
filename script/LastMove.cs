using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastMove : MonoBehaviour
{
    float speed=8;
    private float horizontal;
    private bool isFacingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-0, speed * Time.deltaTime, 0); 
        }
        Flip();
    }

private void Flip()
   {
        horizontal = Input.GetAxisRaw("Horizontal");

     if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
     {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale; 
        localScale.x *= -1f;
        transform.localScale = localScale; 
     }
  }
}
