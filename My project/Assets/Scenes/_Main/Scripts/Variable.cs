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
    public bool isBool;

    [SerializeField] private TMP_InputField _InputField;
    [SerializeField] private TMP_Text _saludo;
    [SerializeField] private Renderer _cube;
    [SerializeField] private BoxCollider _boxCollider;

    
    // Start is called before the first frame update
    void Start()
    {
        _cube.material.color = Color.red;
        _boxCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        myName = _InputField.text;
        _saludo.text = "hola" + myName;

    }
}
