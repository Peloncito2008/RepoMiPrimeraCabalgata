using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
   
    [SerializeField] private Rigidbody2D _rb2D;
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private bool isGround;
    [SerializeField] private float moveSpeed = 5f;
    
    private void Awake()
    {

        _rb2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && isGround)
        {
            _rb2D.AddForce(Vector2.up * fuerzaSalto);
        }

     private void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Horizontal");
        _rb2D.velocity = new Vector2(moveInput * moveSpeed, _rb2D.velocity.y);

        float moveInput2 = Input.GetAxis("Horizontal");
        _rb2D.velocity = new Vector2(moveInput * moveSpeed, _rb2D.velocity.y);
    }


    private void OnCollisionEnter2D(Collision2D collision)
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