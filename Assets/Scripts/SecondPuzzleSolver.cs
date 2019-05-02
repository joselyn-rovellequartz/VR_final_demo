using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPuzzleSolver : MonoBehaviour
{
    public GameObject ToyBoxFloor;
    BoxCollider ToyBoxCol;
    public GameObject BlueButton;
    public GameObject GreenButton;
    public GameObject RedButton;
    public GameObject YellowButton;
    public GameObject WaterGate;
    public int points = 1;
    public float tolerance;
    private int totalPoints = 0;
    private float mToyBoxFloorHeight;
    public delegate void OnPlaced(int pts);
    public static event OnPlaced onButtonPlaced;

    // Start is called before the first frame update
    void Start()
    {
        /*Vector3 ToyBoxPosition = ToyBox.transform.position;
        Vector3 BlueButtonPosition = BlueButton.transform.position;
        Vector3 GreenButtonPosition = GreenButton.transform.position;
        Vector3 RedButtonPosition = RedButton.transform.position;
        Vector3 YellowButtonPosition = YellowButton.transform.position;
        
        if (ToyBoxPosition.y < BlueButtonPosition.y && (BlueButtonPosition.y - ToyBoxPosition.y) < mToyBoxFloorHeight + tolerance
            && Mathf.Abs(BlueButtonPosition.x - ToyBoxPosition.x) < tolerance
            && Mathf.Abs(BlueButtonPosition.z - ToyBoxPosition.z) < tolerance)*/
        mToyBoxFloorHeight = ToyBoxFloor.GetComponent<Renderer>().bounds.size.y;
        ToyBoxCol = ToyBoxFloor.GetComponent<BoxCollider>();
        totalPoints = 0;
    }

    int BlueButtonInBox(int points)
    {
        Vector3 ToyBoxPosition = ToyBoxFloor.transform.position;
        Vector3 BlueButtonPosition = BlueButton.transform.position;

      if (ToyBoxPosition.y < BlueButtonPosition.y)
        {
            points = points + 1;
            return points;
        }
        else
        {
            return points;
        }

    }

    int GreenButtonInBox( int points)
    {
        Vector3 ToyBoxPosition = ToyBoxFloor.transform.position;
        Vector3 GreenButtonPosition = GreenButton.transform.position;
        if (ToyBoxPosition.y < GreenButtonPosition.y)
        {
            points = points + 1;
            return points;
        }
        else
        {
            return points;
        }

    }
    int YellowButtonInBox()
    {
        Vector3 ToyBoxPosition = ToyBoxFloor.transform.position;
        Vector3 YellowButtonPosition = YellowButton.transform.position;
        if (ToyBoxPosition.y < YellowButtonPosition.y)
        {
            points = points + 1;
            return points; 
        }
        else
        {
            return points;
        }

    }
    int RedButtonInBox(int points)
    {
        Vector3 ToyBoxPosition = ToyBoxFloor.transform.position;
        Vector3 RedButtonPosition = RedButton.transform.position;
        if (ToyBoxPosition.y < RedButtonPosition.y)
        {
            points = points + 1;
            return points;
        }
        else
        {
            return points;
        }

    }


    bool IsSolved()
    {
        if (points > 600)
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
        BlueButtonInBox(points);
        GreenButtonInBox(points);
        RedButtonInBox(points);
        YellowButtonInBox();
        totalPoints += points;
        if (IsSolved() == true)
        {
            float changeInHeight = Time.deltaTime * 2;

            Vector3 WaterGateMove = new Vector3(0, changeInHeight, 0);

            WaterGate.transform.position += WaterGateMove;

        }
    }
}
