using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObje : MonoBehaviour
{

    public void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 1);
    }
}
