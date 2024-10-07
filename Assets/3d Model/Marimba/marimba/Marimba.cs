using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Marimba : MonoBehaviour
{
    public AudioSource sounds;
    public ParticleSystem emoji;
    public UnityEvent ExplodeInvoke;
    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sticks"))
        {
            sounds.Play();
            ExplodeInvoke.Invoke();
          //  emoji.Play();


        }
    }
}
