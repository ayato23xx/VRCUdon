
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class tlsw : UdonSharpBehaviour
{
    void Start()
    {
        
    }
    public GameObject tlswobj;
    public override void Interact()
    {
        //base.Interact();
        tlswobj.SetActive(!tlswobj.activeSelf);
    }
}
