using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This script makes the object change 
 * */
[RequireComponent(typeof(Collider))]
public class ToggleColor : MonoBehaviour
{
    [SerializeField]
    private Color newColor = Color.blue;
    private Color color;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Toggle color registered");
        // Make sure the root collider is a trigger and enabled
        Collider rootCollider = GetComponent<Collider>();
        rootCollider.enabled = true;
        //rootCollider.isTrigger = true;

        Renderer renderer = GetComponent<Renderer>();
        color = renderer.material.color;

    }

    // Update is called once per frame
    void Update()
    {
        bool isPlayerNear = false;
        Collider[] hitColliders = Physics.OverlapSphere(transform.localPosition, 2);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.gameObject.tag == "Player")
            {
                //Debug.Log("Player is near");
                isPlayerNear = true;
            }
        }

        GetComponent<Renderer>().material.color = isPlayerNear == true ?  newColor : color;
    }


    // TODO: Why does this not fire?
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("On collision enter");
        Debug.Log(collision);
    }


}
