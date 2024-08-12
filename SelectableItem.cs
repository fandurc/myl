
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class SelectableItem : MonoBehaviour, IPointerClickHandler
{
    public Color selectedColor;
    public Color originalColor;

    private Carta carta;
    private Image image;

    private ContadorTotalCartas contadorTotalCartas;

    void Start()
    {
        carta = GetComponent<Carta>();
        image = GetComponent<Image>();
        contadorTotalCartas = FindObjectOfType<ContadorTotalCartas>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            // Verificar si se puede seleccionar más de esta carta y si el contador general lo permite
            if (contadorTotalCartas.PuedeSeleccionar() && carta.Contador < (carta.unica ? 1 : 3))
            {
                carta.Contador++;
                image.color = selectedColor;

                // Actualizar el contador total
                contadorTotalCartas.ActualizarContador(1);
            }
        }
        else if (eventData.button == PointerEventData.InputButton.Right && carta.Contador > 0)
        {
            carta.Contador--;
            contadorTotalCartas.ActualizarContador(-1);

            // Si el contador de la carta vuelve a 0, desmarcar la carta
            if (carta.Contador == 0)
            {
                image.color = originalColor;
            }
        }
    }
}
