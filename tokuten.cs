
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class tokuten : UdonSharpBehaviour
{
    //変数宣言//
    public GameObject Item;
    public int Tokuten_ = 0;
    public Text Tokuten_text;

    void Start()
    {
        
    }

    public void GetToluten()
    {
        Tokuten_ = Tokuten_+10;
        Tokuten_text.text = Tokuten_.ToString();
        //VRCInstantiate(Item);
        //VRCInstantiate(Item_text);
        Debug.Log("Cubeが消えました");
        Debug.Log(Tokuten_);
    }
}
