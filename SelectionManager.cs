using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    public static SelectionManager Instance { get; private set; }

    public Transform selectedCardsContainer; // Contenedor para las cartas seleccionadas
    public GameObject selectedCardPrefab; // Prefab para la carta seleccionada

    private Dictionary<Carta, GameObject> selectedCards = new Dictionary<Carta, GameObject>();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ActualizarSeleccion(Carta carta, bool seleccionada)
    {
        if (seleccionada)
        {
            if (!selectedCards.ContainsKey(carta))
            {
                // Añadir carta seleccionada
                GameObject nuevaCarta = Instantiate(selectedCardPrefab, selectedCardsContainer);
                Image cartaImage = nuevaCarta.GetComponent<Image>();
                cartaImage.sprite = carta.GetComponent<Image>().sprite;

                // Configurar contador de la carta seleccionada
                TextMeshProUGUI contadorText = nuevaCarta.GetComponentInChildren<TextMeshProUGUI>();
                contadorText.text = carta.Contador.ToString();
                contadorText.color = carta.Contador > 0 ? Color.green : Color.white;

                selectedCards[carta] = nuevaCarta;
            }
            else
            {
                // Actualizar el contador de la carta seleccionada
                GameObject cartaSeleccionada = selectedCards[carta];
                TextMeshProUGUI contadorText = cartaSeleccionada.GetComponentInChildren<TextMeshProUGUI>();
                contadorText.text = carta.Contador.ToString();
                contadorText.color = carta.Contador > 0 ? Color.green : Color.white;
            }
        }
        else
        {
            // Eliminar carta deseleccionada
            if (selectedCards.ContainsKey(carta))
            {
                Destroy(selectedCards[carta]);
                selectedCards.Remove(carta);
            }
        }
    }
}
