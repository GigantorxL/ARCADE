using UnityEngine;
using System.Collections;
 
public class CameraFacingBillboard : MonoBehaviour
{
    //public Camera m_Camera;
    public Camera FirstPersonCamera;

    //Orient the camera after all movement is completed this frame to avoid jittering
    void Update()
    {


        Vector3 dir = FirstPersonCamera.transform.position - transform.position;
        dir.x = 0; // keep the direction strictly horizontal
        Quaternion rot = Quaternion.LookRotation(dir);
        // slerp to the desired rotation over time
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, 2f * Time.deltaTime);

    }
}