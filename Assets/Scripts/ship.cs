using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ship : MonoBehaviour

{

    [SerializeField]
    private float speedX;
    private float shipWidth;


    [SerializeField] private float resetXPosition;
   

    [SerializeField]private scoreCounter score;

    
    // Start is called before the first frame update
    void Start()
    {
        shipWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }



    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(speedX * Time.deltaTime, 0f, 0f);
        if (transform.position.x + (shipWidth / 2f) < 0)
        {
            transform.position = new Vector3(resetXPosition, transform.position.y, transform.position.z);
        }

    }

    private void OnMouseDown()
    {
        transform.position = new Vector3(resetXPosition, transform.position.y, transform.position.z);
        score.score += 1;
        
    }
}

