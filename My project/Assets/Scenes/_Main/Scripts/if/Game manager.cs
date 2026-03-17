using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int healthPlayer = 100;
    [SerializeField] private PlayerControl playerControl;
    [SerializeField] private UiManager UiManager;
    public void Sumarvida(int heal)
    {
        if (healthPlayer < 100)
        {
            healthPlayer += heal;
        }

        else
        {
            healthPlayer = 100;
            Debug.Log("No curo");
        }
    }
    public void Damage(int _Damage)

    {
        if (healthPlayer > 0)
        {
            healthPlayer -= _Damage;
            Debug.Log("restar" + _Damage + "puntos de vida");

        }

        if (healthPlayer <= 0)
        {
            Destroy(playerControl.gameObject);
            Debug.Log("Se muriooo");
        }
        if (healthPlayer >= 80)
        {
            UiManager.ColorBarraDevida(Color.green);
        }

        if (healthPlayer < 80)

        {
            UiManager.ColorBarraDevida(Color.yellow);

        }

        if (healthPlayer == 20)
        {

            UiManager.ColorBarraDevida(Color.yellow);
        }

        if (healthPlayer < 20)
        {
            UiManager.ColorBarraDevida(Color.red);
        }


    }
}














