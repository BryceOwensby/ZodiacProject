using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    private Transform target;
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Unit").GetComponent<Transform>();
        if (Vector2.Distance(transform.position, target.position) == 0)
        {
            Object.Destroy(myPrefab);
        }
    }
}
