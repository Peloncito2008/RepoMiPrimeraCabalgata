
using UnityEngine;
using UnityEngine.UI;


public class UiManager : MonoBehaviour
{
    [SerializeField] private Image _barraDevida;

    private void Start()
    {
        _barraDevida.color = Color.green;
        _barraDevida.fillAmount = 1; 

    }
    public void ColorBarraDevida(Color color) 
    {
        _barraDevida.color = color;
    }
    public void FillamountBarradeVida (float fillAmount)
    {
        _barraDevida.fillAmount = fillAmount;
    }
}
