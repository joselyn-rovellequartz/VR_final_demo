using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenerController : MonoBehaviour
{
    // units to move block per degree of dial rotation
    public float unitsPerDegree = 0.001f;
    private GameObject mDial;
    private GameObject mBlock;
    private Vector3 mPrevDialRotation;
    public Vector3 axis = Vector3.up;
    void Start()
    {
        // get references to our dial and block game objects
        mBlock = transform.Find("Block").gameObject;
     
       
     GameObject handController =
       transform.Find("HandController").gameObject;
        GameObject controllerBase =
        handController.transform.Find("Base").gameObject;
        mDial = controllerBase.transform.Find("Dial").gameObject;
        // get initial rotation angle of dial
        mPrevDialRotation = mDial.transform.localEulerAngles;
        //getComponent<Collider>().enabled = false;
    }

    void Update()
    {
        // get current rotation angle of dial
        Vector3 curDialRotation = mDial.transform.localEulerAngles;
        // If the dial has rotated since the last frame update the position
        // of the block. Dial is rotating around the Y axis.
        if (curDialRotation != mPrevDialRotation)
        {
            float dialRotation = curDialRotation.y - mPrevDialRotation.y;
            // check if dial was rotated past 12 o'clock
            if (mPrevDialRotation.y > 270 && curDialRotation.y < 90)
            {
                // dial rotated clockwise past 12 o'clock
                dialRotation += 360;
            }
            else if (mPrevDialRotation.y < 90 && curDialRotation.y > 270)
            {
                // dial rotated counterclockwise past 12 o'clock
                dialRotation -= 360;
            }
            float blockMoveDist = unitsPerDegree * dialRotation;
            // Move the block
            // mBlock.transform.Translate(new Vector3(0, blockMoveDist, 0));
            mBlock.transform.Translate(axis * blockMoveDist);
            mPrevDialRotation = curDialRotation;
        }
    }
}