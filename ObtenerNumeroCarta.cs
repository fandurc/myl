using UnityEngine;
using UnityEngine.EventSystems;
using TMPro; // Importa esta librería si usas TextMeshPro

public class ObtenerNumeroCarta : MonoBehaviour, IPointerEnterHandler
{
    private Carta cartaScript; // Referencia al script Carta que contiene el número
    public TextMeshProUGUI textoNumeroCarta; // Referencia al texto en la UI donde se mostrará el número

    void Start()
    {
        cartaScript = GetComponent<Carta>();

        if (cartaScript == null)
        {
            Debug.LogError("No se encontró el script Carta en " + gameObject.name);
        }

        if (textoNumeroCarta == null)
        {
            Debug.LogError("No se ha asignado el objeto TextoNumeroCarta en el Inspector.");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (cartaScript != null && textoNumeroCarta != null)
        {
            int numeroCarta = cartaScript.numero; // Obtener el número de la carta
            textoNumeroCarta.text = "Número de la carta: " + numeroCarta; // Mostrar el número en el texto UI
        }
    }
}

