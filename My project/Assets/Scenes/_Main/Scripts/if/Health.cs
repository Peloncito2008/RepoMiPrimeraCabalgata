using Unity.VisualScripting;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private GameManager gamemanager;
    [SerializeField] private int heal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gamemanager.Sumarvida(heal);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }














}
