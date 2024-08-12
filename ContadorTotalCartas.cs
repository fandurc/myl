using TMPro;
using UnityEngine;

public class ContadorTotalCartas : MonoBehaviour
{
    public int contadorTotal = 0;
    public int limiteTotal = 50; // El límite máximo de cartas seleccionadas
    public TextMeshProUGUI contadorText; // El componente de texto para mostrar el contador

    public void ActualizarContador(int incremento)
    {
        contadorTotal += incremento;
        contadorTotal = Mathf.Clamp(contadorTotal, 0, limiteTotal);
        contadorText.text = contadorTotal.ToString();
    }

    public bool PuedeSeleccionar()
    {
        return contadorTotal < limiteTotal;
    }
}

