using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliders : MonoBehaviour
{
    public int points = 1;
    private int totalPoints = 0;
    public delegate void OnPlaced(int pts);
    public static event OnPlaced onButtonPlaced;

    void OnTriggerEnter(Collider other)
    {
        onButtonPlaced?.Invoke(points);

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
