using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPuzzleController : MonoBehaviour
{
    public float tolerance;
    public GameObject mFourthBlock;
    //private GameObject mFifthBlock;
    public GameObject mSecondBlock;
    private float mFourthHeight;
   
    public delegate void OnSolved();
    public static event OnSolved onPuzzleSolved;
    void Start()
    {
        
        mFourthHeight = mFourthBlock.GetComponent<Renderer>().bounds.size.x;
    }
    // Return true if puzzle is solved.
    bool IsSolved()
    {
        Vector3 FourthPosition = mFourthBlock.transform.position;
        Vector3 SecondPosition = mSecondBlock.transform.position;
     
        if (SecondPosition.x > FourthPosition.x
        && (SecondPosition.x - FourthPosition.x) < mFourthHeight + tolerance
        && Mathf.Abs(SecondPosition.x - FourthPosition.x) < tolerance
        && Mathf.Abs(SecondPosition.z - FourthPosition.z) < tolerance)





        {
            return true;
        }
        return false;
    }
    void Update()
    {
        if (IsSolved() == true)
        {
            // Puzzle has been solved. Turn blocks grey.
            mFourthBlock.GetComponent<Renderer>().material.color = Color.grey;
           // mFifthBlock.GetComponent<Renderer>().material.color = Color.grey;
            mSecondBlock.GetComponent<Renderer>().material.color = Color.grey;


        }
    }
}