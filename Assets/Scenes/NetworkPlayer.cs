using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Photon.Pun;

public class NetworkPlayer : MonoBehaviour
{
    public Transform head;
    public Transform leftHand;
    public Transform rightHand;

    private PhotonView photonView;
// Start is called before the first frame update
    void Start()
    {
    photonView = GetComponent<PhotonView>();
    }
    // Update is called once per frame
    void Update()
    {
        if(photonView.IsMine){
          rightHand.gameObject.SetActive(true);  
          leftHand.gameObject.SetActive(true);  
          head.gameObject.SetActive(true);  
          
            MapPosition(head,XRNode.Head);
            MapPosition(head,XRNode.LeftHand);
            MapPosition(head,XRNode.RightHand);
        }
       
        
    }
    void MapPosition(Transform target, XRNode node){
    InputDevices.GetDeviceAtXRNode(node).TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 position);
    InputDevices.GetDeviceAtXRNode(node).TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion rotation);

    target.position = position;
    target.rotation = rotation;
        
    }
}