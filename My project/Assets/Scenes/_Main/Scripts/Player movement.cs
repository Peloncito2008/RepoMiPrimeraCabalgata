using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private float x = 0;
    [SerializeField] private Rigidbody2D _rb2D;
    public float velocidad = 10f;
    private void Start()
    {
        _transform.position = new Vector3(5f, 3.85f, 0f);
    }
    private void FixedUpdate()
    {
        x += 0.1f;
        _rb2D.velocity = Vector2.right * velocidad;
        //x++;
        // x ++ = x+1
        //_transform.position = new Vector3(x, 3.85f, 0f);
        // +
        // -
        // *
        // &&
        // ||
        // <
        // >
        // =
        // ==
        // !
        // !=
        // >=
        // +=
        // ++
        // --
    }

}