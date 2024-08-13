/*
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
public class InstanciarCartas : MonoBehaviour
{
    public GameObject cartaPrefab;
    public Transform gridTransform;
    public List<Image> cartasEnHierarchy;
    public Color selectedColor = Color.green;
    public Color originalColor = Color.white;

    private List<int> espacioCartas = new List<int>();

    void Start()
    {
        for (int i = 0; i < cartasEnHierarchy.Count; i++)
        {
            GameObject nuevaCarta = Instantiate(cartaPrefab, gridTransform);
            Image cartaImage = nuevaCarta.GetComponent<Image>();
            cartaImage.sprite = cartasEnHierarchy[i].sprite;

            Carta scriptCarta = nuevaCarta.GetComponent<Carta>();
            scriptCarta.numero = cartasEnHierarchy[i].GetComponent<Carta>().numero;
            scriptCarta.tipoCarta = cartasEnHierarchy[i].GetComponent<Carta>().tipoCarta;
            scriptCarta.rareza = cartasEnHierarchy[i].GetComponent<Carta>().rareza;
            scriptCarta.unica = cartasEnHierarchy[i].GetComponent<Carta>().unica;
            scriptCarta.contadorText = nuevaCarta.GetComponentInChildren<TextMeshProUGUI>();

            // Guardar el n�mero de espacio correlativo
            espacioCartas.Add(i + 1);

            // Agregar el componente SelectableItem
            SelectableItem selectableItem = nuevaCarta.AddComponent<SelectableItem>();
            selectableItem.selectedColor = selectedColor;
            selectableItem.originalColor = originalColor;

            // A�adir evento para mostrar n�mero de espacio y n�mero de carta
            nuevaCarta.AddComponent<MostrarNumeroCarta>().Configurar(i + 1, scriptCarta.numero);
        }
    }
}*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class InstanciarCartas : MonoBehaviour
{
    public GameObject cartaPrefab;
    public Transform gridTransform;
    public List<Image> cartasEnHierarchy;
    public Color selectedColor = Color.green;
    public Color originalColor = Color.white;

    private List<int> espacioCartas = new List<int>();

    void Start()
    {
        for (int i = 0; i < cartasEnHierarchy.Count; i++)
        {
            GameObject nuevaCarta = Instantiate(cartaPrefab, gridTransform);
            Image cartaImage = nuevaCarta.GetComponent<Image>();

            Carta scriptCarta = nuevaCarta.GetComponent<Carta>();
            scriptCarta.numero = cartasEnHierarchy[i].GetComponent<Carta>().numero;
            scriptCarta.tipoCarta = cartasEnHierarchy[i].GetComponent<Carta>().tipoCarta;
            scriptCarta.rareza = cartasEnHierarchy[i].GetComponent<Carta>().rareza;
            scriptCarta.unica = cartasEnHierarchy[i].GetComponent<Carta>().unica;
            scriptCarta.contadorText = nuevaCarta.GetComponentInChildren<TextMeshProUGUI>();

            // Aqu� es donde asignamos el sprite al campo imagenCarta
            scriptCarta.imagenCarta = cartasEnHierarchy[i].GetComponent<Carta>().imagenCarta;

            // Luego, asignamos la imagen del componente Image desde el campo imagenCarta
            cartaImage.sprite = scriptCarta.imagenCarta;

            // Guardar el n�mero de espacio correlativo
            espacioCartas.Add(i + 1);

            // Agregar el componente SelectableItem
            SelectableItem selectableItem = nuevaCarta.AddComponent<SelectableItem>();
            selectableItem.selectedColor = selectedColor;
            selectableItem.originalColor = originalColor;

            // A�adir evento para mostrar n�mero de espacio y n�mero de carta
            nuevaCarta.AddComponent<MostrarNumeroCarta>().Configurar(i + 1, scriptCarta.numero, cartaImage.sprite);
        }
    }
}
