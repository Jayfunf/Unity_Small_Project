using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallmove : MonoBehaviour
{
    public float wallSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;
        moveVelocity = new Vector3(-0.12f, 0, 0);
        transform.position += moveVelocity * wallSpeed * Time.deltaTime;

        if(transform.position.y < -7f)
        {
            Destroy(gameObject);
        }
        
    }
    
}
