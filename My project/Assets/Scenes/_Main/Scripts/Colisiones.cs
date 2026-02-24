using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Algo me esta tocando UwU");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Algo me toco 7W7");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("OnCollision2D collision");
    }
   

}
