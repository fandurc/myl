
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class MostrarNumeroCorrelativo : MonoBehaviour, IPointerEnterHandler
{
    public TextMeshProUGUI textoNumeroCorrelativo; // Referencia al texto en la UI para mostrar el n�mero correlativo
    private int numeroCorrelativo; // El n�mero correlativo de esta carta

    // M�todo para asignar el n�mero correlativo desde InstanciarCartas
    public void AsignarNumeroCorrelativo(int numero)
    {
        numeroCorrelativo = numero;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (textoNumeroCorrelativo != null)
        {
            // Mostrar el n�mero correlativo en el texto UI
            textoNumeroCorrelativo.text = numeroCorrelativo.ToString();
        }
    }
}




