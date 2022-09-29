using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class unpressButoon : MonoBehaviour
{
    public UnityEvent buttonPressedEvent;

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            buttonPressedEvent?.Invoke();

        }

    }
}
