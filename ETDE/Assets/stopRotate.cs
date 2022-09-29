using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopRotate : MonoBehaviour
{
    public float rotatingSpeed;
    //public float clampValue = 0;
    public int rotate = -1;
    public int reverse = -1;
    public int caseHolder = 0;
    



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (caseHolder)
        {

            case 1:
                if (rotate >= 1)
                {

                    if (reverse >= 1)
                    {
                        transform.Rotate(-Vector3.forward, Time.deltaTime * rotatingSpeed);
                        
                    }
                    else
                    {
                        transform.Rotate(Vector3.forward, Time.deltaTime * rotatingSpeed);
                        
                    }

                }

                break;

            case 2:
                if (rotate >= 1)
                {

                    if (reverse >= 1)
                    {
                        transform.Rotate(-Vector3.right, Time.deltaTime * rotatingSpeed);

                    }
                    else
                    {
                        transform.Rotate(Vector3.right, Time.deltaTime * rotatingSpeed);
                    }

                }
                

                break;

             case 3:
                 if (rotate >= 1)
                 {

                     if (reverse >= 1)
                     {
                         transform.Translate(-Vector3.right * Time.deltaTime / 100 * rotatingSpeed);

                     }
                     else
                     {
                         transform.Translate(Vector3.right * Time.deltaTime / 100 * rotatingSpeed);

                     }

                 }

                 break;
            



            default:
                if (rotate >= 1)
                {

                    if (reverse >= 1)
                    {
                        transform.Rotate(-Vector3.up, Time.deltaTime * rotatingSpeed);

                    }
                    else
                    {
                        transform.Rotate(Vector3.up, Time.deltaTime * rotatingSpeed);

                    }

                }


                break;

        }
        


    }

    public void DoRotateXaxis()
    {
        rotate = rotate * -1;
        caseHolder = 2;

    }

    public void DoReverseXaxis()
    {
        reverse = reverse * -1;
        rotate = rotate * -1;

        caseHolder = 2;

    }

    public void DoRotateZaxis()
    {
        rotate = rotate * -1;

        caseHolder = 1;

    }

    public void DoReverseZaxis()
    {
        reverse = reverse * -1;
        rotate = rotate * -1;

        caseHolder = 1;
    }

    public void DoRotateYaxis()
    {
        rotate = rotate * -1;

        caseHolder = 0;

    }

    public void DoReverseYaxis()
    {
        reverse = reverse * -1;
        rotate = rotate * -1;

        caseHolder = 0;
    }

    public void DoSlideRight()
    {
        
        rotate = rotate * -1;

        caseHolder = 3;
    }

    public void DoSlideLeft()
    {

        reverse = reverse * -1;
        rotate = rotate * -1;


        caseHolder = 3;
    }






    public void FullSstop()
    {   
        if(rotate == 0)
        {
            rotate = 1;
        }
        else
        {
            if(rotate == 1)
            {
                rotate = 0;
            }
        }

        if (reverse == 0)
        {
            reverse = 1;
        }
        else
        {
            if (reverse == 1)
            {
                reverse = 0;
            }
        }

    }
    public void Collision()
    {
        rotate = -1;
        reverse = -1;

    }
}

