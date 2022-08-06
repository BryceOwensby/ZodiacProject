using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiationExample : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 5f;
            transform.position = mousePos;
            {
                Debug.Log(mousePos.x + ", " + mousePos.y);
                Debug.Log(mousePos.x / 100 + ", " + mousePos.y / 100);
            }
            Instantiate(myPrefab, new Vector3(mousePos.x, mousePos.y, 0), Quaternion.identity);
        }
    }
}
