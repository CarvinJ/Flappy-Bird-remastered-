using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesContrllor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        (Vector2.left * Time.deltaTime * speed);

    }

    // Update is called once per frame
    void Update()
    {
        // Move pipes left
        transform.Translate(Vector2.left * Time.deltaTime * speed);

        // Destroy pipes off screen
        if (transform.position.magnitude > 20f)
        {
            Destroy(gameObject);
            
        }
    }    
}
