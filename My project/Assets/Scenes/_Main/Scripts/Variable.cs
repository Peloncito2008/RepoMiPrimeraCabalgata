using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    // Variables
    public string myName = "Rodolfo";
   public int edad = 17;

    [SerializeField] private TMP_InputField _InputField;
    [SerializeField] private TMP_Text _saludo;



    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myName = _InputField.text;
        _saludo.text = "hola" + myName;

    }
}
