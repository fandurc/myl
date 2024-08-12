
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class MostrarNumeroCarta : MonoBehaviour, IPointerEnterHandler
{
    private int numeroEspacio;
    private int numeroCarta;

    public void Configurar(int espacio, int numero)
    {
        numeroEspacio = espacio;
        numeroCarta = numero;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Asume que tienes un TextMeshProUGUI para mostrar el número en pantalla
        TextMeshProUGUI displayText = GameObject.Find("EspacioNumeroText").GetComponent<TextMeshProUGUI>();
        displayText.text = "Espacio: " + numeroEspacio + " - Carta: " + numeroCarta;
    }
}
