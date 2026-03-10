using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] private int vidajugador

    public void SumarVida(int vida)
    {
     
        
        if (vidajugador < 100)
        {
            vidajugador = 100;
        }
        else 
        {
            Debug.Log("no cura");
        }
        
    }
}
