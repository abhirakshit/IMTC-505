using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateinPlace : MonoBehaviour
{
    public Transform centerObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Test");

        //transform.RotateAround(centerObject.position, centerObject.up, 20 * Time.deltaTime);
        transform.Rotate(new Vector3(0f, 1f));

    }
}
