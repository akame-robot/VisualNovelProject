

using System;
using UnityEngine;
using UnityEngine.UI;


public class GetValue : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform popup;
     public Dropdown lingua;
    Int32 lalal;
   
   
    void Start()
    {
       lingua= GetComponent<Dropdown>();    
    }

    // Update is called once per frame
    void Update()
    {
        lalal = lingua.value;
        Debug.Log(lalal);
        // Tradutor.language=lingua.transform.GetComponent<Dropdown>().value;
    }
}
