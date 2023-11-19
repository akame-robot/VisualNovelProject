

using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GetValue : MonoBehaviour
{
    // Start is called before the first frame update
   
    public TMP_Dropdown dropdwon;


    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
         Tradutor.language= dropdwon.value;
    }
}
