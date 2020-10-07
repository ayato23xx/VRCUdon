
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MirrorSW : UdonSharpBehaviour
{
    void Start()
    {
        
    }
    public GameObject Mirror;
    public override void Interact()
    {
        Mirror.SetActive(!Mirror.activeSelf);
    }
}
