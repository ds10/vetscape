using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class intToVar : MonoBehaviour
{

    public Flowchart flowchart;
    Text txt;


    void Start()
    {
        txt = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int intCash = flowchart.GetIntegerVariable("cash");
        string strCash = intCash.ToString();
        txt.text = "Cash : " + strCash;
    }

    string converter(){
        int intCash = flowchart.GetIntegerVariable("cash");
        string strCash = intCash.ToString();
        return (strCash);
    }
}