
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class Clock : UdonSharpBehaviour
{
    void Start()
    {

    }

    public Text timetext;
    public Text timetext2;

    private void Update()
    {
        timetext2.text = string.Format("{0:yyy年MM月dd日}", System.DateTime.Now);
        timetext.text = string.Format("{0:HH:mm:ss}", System.DateTime.Now);
    }
}
