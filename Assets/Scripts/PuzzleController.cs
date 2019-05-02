using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    public float tolerance;
    //private GameObject mFirstBlock;
    public GameObject mThirdBlock;
    public GameObject mSecondBlock;
    //private GameObject mThirdBlock;
    private float mSecondHeight;
    //private float mSecondHeight;
    public delegate void OnSolved();
    public static event OnSolved onPuzzleSolved;
    void Start()
    {
        mThirdBlock = transform.Find("ThirdBlock").gameObject;
        mSecondBlock = transform.Find("SecondBlock").gameObject;
        //mThirdBlock = transform.Find("ThirdBlock").gameObject;
        mSecondHeight = mSecondBlock.GetComponent<Renderer>().bounds.size.x;
    }
    // Return true if puzzle is solved.
    bool IsSolved()
    {
        Vector3 ThirdPosition = mThirdBlock.transform.position;
        Vector3 SecondPosition = mSecondBlock.transform.position;
        //Vector3 ThirdPosition = mThirdBlock.transform.position;
        if (ThirdPosition.x > SecondPosition.x
        && (ThirdPosition.x - SecondPosition.x) < mSecondHeight + tolerance
        && Mathf.Abs(ThirdPosition.y - SecondPosition.y) < tolerance
        && Mathf.Abs(ThirdPosition.x - SecondPosition.x) < tolerance)


        {
           
            return true;
        }
        return false;
    }
    void Update()
    {
        if (IsSolved() == true)
        {
            
            mThirdBlock.GetComponent<Renderer>().material.color = Color.red;
            mSecondBlock.GetComponent<Renderer>().material.color = Color.blue;
            //mFirstBlock.GetComponent<Renderer>().material.color = Color.blue;

           
        }
    }
}