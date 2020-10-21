
using UdonSharp;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class Item1 : UdonSharpBehaviour
{
    //変数宣言//
    public GameObject Item;
    public GameObject Item_text;
    public GameObject Sword;
    public GameObject DaiaSword;
    public GameObject TokutenCS;
    public Text Dt_Text;
    public int Itemhp = 500;

    void Start()
    {
        //
    }

    public void OnTriggerEnter(Collider hit)
    {
        //DSword使用時
        if (hit.name == "DSword")
        {
            Itemhp = Itemhp - 250;
            if (Itemhp <= 0)
            {
                TokutenCS.GetComponent<tokuten>().GetToluten();
                Destroy(Item);
            }
            Dt_Text.text = Itemhp.ToString();
        }
        //Sword使用時
        else if (hit.name == "Sword")
        {
            Itemhp = Itemhp - 50;
            if(Itemhp <= 0)
            {
                TokutenCS.GetComponent<tokuten>().GetToluten();
                Destroy(Item);
            }
            Dt_Text.text = Itemhp.ToString();
        }
        //何もない時
        else
        {
            Dt_Text.text = "null";
            Debug.Log("null");
            return;
        }
        
    }

}
