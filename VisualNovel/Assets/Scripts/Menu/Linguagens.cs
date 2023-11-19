using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;


public class Linguagens : Tradutor
{
    [SerializeField] private List<TextMeshProUGUI> allText;
  
    public TMP_FontAsset japonesFonte, chinesFonte, portFonte;
    public TMP_Dropdown dropdwon;

    [SerializeField] private List<string> portuguesBr, ingles, japones, chines;
  

    // Start is called before the first frame update
    void Start()
    {
        TrocaLinguagem();



    }

    // Update is called once per frame
    void Update()
    {
        //valor = popup.GetChild(0).GetComponent<Dropdown>().value;
        //Debug.Log(valor);   

    }

    public void TrocaLinguagem()
    {

        Tradutor.language = dropdwon.value;
        switch (dropdwon.value)
        {
            case 0:
                TrocaFonte(allText, portFonte);
                Tradusindo(allText, portuguesBr);
                break;
            case 1:
                TrocaFonte(allText, portFonte);
                Tradusindo(allText, ingles);
                break;
            case 2:
                TrocaFonte(allText, japonesFonte);
                Tradusindo(allText, japones);
                break;
            case 3:
                TrocaFonte(allText,chinesFonte);    
                Tradusindo(allText, chines);
                break;
        }
    }

    
}
    

