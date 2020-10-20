
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class Item1 : UdonSharpBehaviour
{
    void Start()
    {

    }

    public GameObject Item;
    public GameObject Sword;
    public GameObject DaiaSword;
    public Text Tokuten;
    public Text Dt_Text;
    public int Itemhp = 500;
    public int Tokuten_ = 0;

    private void OnTriggerEnter(Collider hit)
    {
        //DSword使用時
        if (hit.name == "DSword")
        {
            Itemhp = Itemhp - 250;
            if (Itemhp <= 0)
            {
                Destroy(Item);
                Tokuten_ += 10;
                Debug.Log(Tokuten_);

            }
            Debug.Log(Tokuten_);
            Tokuten.text = Tokuten_.ToString();
            Dt_Text.text = Itemhp.ToString();
            //Debug.Log(hit.name);
            //Debug.Log(Itemhp);
        }
        //Sword使用時
        else if (hit.name == "Sword")
        {
            Itemhp = Itemhp - 50;
            if(Itemhp <= 0)
            {
                Destroy(Item);
                Tokuten_ = Tokuten_ += 10;
                //Tokuten.text = Tokuten_.ToString();
            }
            Tokuten.text = Tokuten_.ToString();
            Dt_Text.text = Itemhp.ToString();
            //Debug.Log(hit.name);
            //Debug.Log(Itemhp);
        }
        //何もない時
        else
        {
            Dt_Text.text = "null";
            Debug.Log("null");
            return;
        }
        
    }
    private void OnDestroy()
    {
        if (!Item) { Debug.Log("naiyo"); }
    }

}
