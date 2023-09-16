using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ToggleColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Toggle color registered");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("On collision enter");
        Debug.Log(collision);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("On collision enter 2d");
        Debug.Log(collision);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("On trigger enter");
    }
}
