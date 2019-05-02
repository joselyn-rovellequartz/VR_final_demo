using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPuzzleSolver : MonoBehaviour
{
    public GameObject BlueBox;
    public GameObject GreenBox;
    public GameObject RedBox;
    public GameObject YellowBox;
    BoxCollider BlueBoxCol;
    BoxCollider GreenBoxCol;
    BoxCollider RedBoxCol;
    BoxCollider YellowBoxCol;
    public GameObject BlueButton;
    public GameObject GreenButton;
    public GameObject RedButton;
    public GameObject YellowButton;
    public GameObject WaterGate;
    //public delegate void OnSolved();
    //public static event OnSolved onPuzzleSolved;
    // Start is called before the first frame update
    void Start()
    {
        BlueBoxCol = BlueBox.GetComponent<BoxCollider>();
        GreenBoxCol = GreenBox.GetComponent<BoxCollider>();
        RedBoxCol = RedBox.GetComponent<BoxCollider>();
        YellowBoxCol = YellowBox.GetComponent<BoxCollider>();

    }

    bool CorrectButtonToBox()
    {
        if (BlueBoxCol == BlueButton && GreenBoxCol == GreenButton && RedBoxCol == RedButton && YellowBoxCol == YellowButton)
        {
            return true;
        }
        else
        {
            return true;
        }

    }



    bool IsSolved()
    {
        if (CorrectButtonToBox() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (IsSolved() == true)
        {
            float changeInHeight = Time.deltaTime * 2;

            Vector3 WaterGateMove = new Vector3(0, changeInHeight, 0);

            WaterGate.transform.position += WaterGateMove;

        }
    }
}
