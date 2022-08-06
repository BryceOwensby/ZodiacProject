using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    
    private Transform target;
    private SpriteRenderer mySpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Flag").GetComponent<Transform>();
  
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        if (transform.position.x > target.position.x)
        {
            if (mySpriteRenderer != null)
            {
                // flip the sprite
                mySpriteRenderer.flipX = true;
            }
        }
        else if (transform.position.x < target.position.x)
        {
            if (mySpriteRenderer != null)
            {
                // flip the sprite
                mySpriteRenderer.flipX = false;
            }
        }
        
    }
}
