
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class MostrarNumeroCorrelativo : MonoBehaviour, IPointerEnterHandler
{
    public TextMeshProUGUI textoNumeroCorrelativo; // Referencia al texto en la UI para mostrar el número correlativo
    private int numeroCorrelativo; // El número correlativo de esta carta

    // Método para asignar el número correlativo desde InstanciarCartas
    public void AsignarNumeroCorrelativo(int numero)
    {
        numeroCorrelativo = numero;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (textoNumeroCorrelativo != null)
        {
            // Mostrar el número correlativo en el texto UI
            textoNumeroCorrelativo.text = numeroCorrelativo.ToString();
        }
    }
}




