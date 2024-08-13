using UnityEngine;
using UnityEngine.EventSystems;
using TMPro; // Importa esta librer�a si usas TextMeshPro

public class ObtenerNumeroCarta : MonoBehaviour, IPointerEnterHandler
{
    private Carta cartaScript; // Referencia al script Carta que contiene el n�mero
    public TextMeshProUGUI textoNumeroCarta; // Referencia al texto en la UI donde se mostrar� el n�mero

    void Start()
    {
        cartaScript = GetComponent<Carta>();

        if (cartaScript == null)
        {
            Debug.LogError("No se encontr� el script Carta en " + gameObject.name);
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
            int numeroCarta = cartaScript.numero; // Obtener el n�mero de la carta
            textoNumeroCarta.text = "N�mero de la carta: " + numeroCarta; // Mostrar el n�mero en el texto UI
        }
    }
}

