using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class InstanciarCartas : MonoBehaviour
{
    public GameObject cartaPrefab; // Prefab de la carta
    public Transform gridTransform; // Transform del Grid Layout Group
    public List<Image> cartasEnHierarchy; // Lista de imágenes de cartas en el hierarchy
    public Color selectedColor = Color.green; // Color al que cambiará al seleccionarse
    public Color originalColor = Color.white; // Color original de la carta

    void Start()
    {
        foreach (var carta in cartasEnHierarchy)
        {
            GameObject nuevaCarta = Instantiate(cartaPrefab, gridTransform);
            Image cartaImage = nuevaCarta.GetComponent<Image>();
            cartaImage.sprite = carta.sprite;

            // Configura otras propiedades de la carta usando la clase Carta
            Carta scriptCarta = nuevaCarta.GetComponent<Carta>();
            scriptCarta.numero = carta.GetComponent<Carta>().numero;
            scriptCarta.tipoCarta = carta.GetComponent<Carta>().tipoCarta;
            scriptCarta.rareza = carta.GetComponent<Carta>().rareza;
            scriptCarta.unica = carta.GetComponent<Carta>().unica; // Inicializar el nuevo campo
            scriptCarta.contadorText = nuevaCarta.GetComponentInChildren<TextMeshProUGUI>(); // Referencia al componente de texto
            // Configura cualquier otra propiedad que tengas en la clase Carta

            // Agregar el componente SelectableItem
            SelectableItem selectableItem = nuevaCarta.AddComponent<SelectableItem>();
            selectableItem.selectedColor = selectedColor;
            selectableItem.originalColor = originalColor;
        }
    }
}
