using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    Rigidbody2D bird;
    // Start is called before the first frame update
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
    }
     void OnTriggerEnter2D(Collider2D other) 
     {
        if(other.gameobject.CompareTag("Points"))
       {
           // Increase score by 1 
           score = score + 1;

           scoreUI.text = score.ToString();
       } 
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            bird.AddForce(new Vector2(0,1) * 200);
        } 
    }
}
