/*
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
*/

using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class MostrarNumeroCarta : MonoBehaviour, IPointerEnterHandler//, IPointerExitHandler
{
    private int numeroEspacio;
    private int numeroCarta;
    private Sprite imagenCarta;

    public Image imagenCartaGrande; // Imagen grande que se mostrará en la UI

    public void Configurar(int espacio, int numero, Sprite imagen)
    {
        numeroEspacio = espacio;
        numeroCarta = numero;
        imagenCarta = imagen;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Mostrar número de espacio y número de carta
        TextMeshProUGUI displayText = GameObject.Find("EspacioNumeroText").GetComponent<TextMeshProUGUI>();
        displayText.text = "Espacio: " + numeroEspacio + " - Carta: " + numeroCarta;
        /*
        // Mostrar imagen grande de la carta
        if (imagenCartaGrande != null)
        {
        //    Debug.Log("imagenCartaGrande no es null");
            imagenCartaGrande.sprite = imagenCarta;
            imagenCartaGrande.enabled = true; // Asegurarse de que la imagen esté visible
        }
        if (imagenCartaGrande == null)
        {
            Debug.Log("imagenCartaGrande es null");
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Ocultar la imagen grande de la carta cuando el puntero sale de la carta
        if (imagenCartaGrande != null)
        {
            imagenCartaGrande.enabled = false; // Ocultar la imagen
        }*/
    }
}
