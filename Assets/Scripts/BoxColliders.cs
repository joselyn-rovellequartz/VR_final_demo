using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliders : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object entered on trigger");
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Object within trigger");
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Object exited on trigger");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
