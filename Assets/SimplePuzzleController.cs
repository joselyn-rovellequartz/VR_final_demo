using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePuzzleController : MonoBehaviour
{

    public float tolerance;
    private GameObject mRedBlock;
    private GameObject mBlueBlock;
    private float mBlueHeight;
    void Start()
    {
        mRedBlock = transform.Find("RedBlock").gameObject;
        mBlueBlock = transform.Find("BlueBlock").gameObject;
        mBlueHeight = mBlueBlock.GetComponent<Renderer>().bounds.size.y;
    }
    // Return true if puzzle is solved.
    bool IsSolved()
    {
        Vector3 RedPosition = mRedBlock.transform.position;
        Vector3 BluePosition = mBlueBlock.transform.position;
        if (RedPosition.y > BluePosition.y
        && (RedPosition.y - BluePosition.y) < mBlueHeight + tolerance
        && Mathf.Abs(RedPosition.x - BluePosition.x) < tolerance
        && Mathf.Abs(RedPosition.z - BluePosition.z) < tolerance)
        {
            // Red block on top of blue block
            return true;
        }
        return false;
    }
    void Update()
    {
        if (IsSolved() == true)
        {
            // Puzzle has been solved. Turn blocks yellow.
            mRedBlock.GetComponent<Renderer>().material.color = Color.blue;
            mBlueBlock.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}