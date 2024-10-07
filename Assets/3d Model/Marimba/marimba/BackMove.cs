using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BackMove : MonoBehaviour
{
 
    public UnityEvent UIPopUp;

 
    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sticks"))
        {
           UIPopUp.Invoke();   
        }
    }
}
