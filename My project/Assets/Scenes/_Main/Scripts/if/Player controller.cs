using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Unity.VisualScripting;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb2d;
    [SerializeField] private float fuerzaSalto = 125f;
    [SerializeField] private bool isGround;
    [SerializeField] private float moveSpeed = 5f;

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // || &&
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGround)
        {
            _rb2d.AddForce(Vector2.up * fuerzaSalto);
        }


    }

    private void FixedUpdate()
    {

        float movimientoHorizontal = Input.GetAxis("Horizontal");
        _rb2d.velocity = new Vector2(movimientoHorizontal * moveSpeed, _rb2d.velocity.y);

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = false;
        }

    }
}








// Update is called once per frame

//if (_sillueve && _edad >= 18)
//{
//Debug.Log("Empaco la sombrilla");
// }

//else if (_sillueve == true && _edad < 18)
//{
//  Debug.Log("Empaco sombrilla y no puedo votar");
//}