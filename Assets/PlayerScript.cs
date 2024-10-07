using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class PlayerScript : MonoBehaviour
{
    PhotonView view;
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
