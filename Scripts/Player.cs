using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 15f;

    //public float width = 5f;
     public float setWidth = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   void FixedUpdate()
   {
    float x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x,-setWidth,setWidth);

        rb.MovePosition(newPosition);
   }
     
     void OnCollisionEnter2D()
     {
        FindAnyObjectByType<SlowBlocks>().EndGame();
     }
}
