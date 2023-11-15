using System.Collections.Generic;

using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Tradutor : MonoBehaviour
{
   
    public static int language;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Tradusindo(List< TextMeshProUGUI> allText, List<string> traducao)
    {
        int i= 0;
        
        foreach (TextMeshProUGUI text in allText)
        {
            text.text = traducao[i];
            i++;
        }


    }
    public void TrocaFonte(List<TextMeshProUGUI> allText, TMP_FontAsset fonte)
    {
        int i = 0;

        foreach (TextMeshProUGUI text in allText)
        {
            text.font=fonte;
            i++;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
