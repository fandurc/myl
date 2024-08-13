
using UnityEngine;
using TMPro;

public class Carta : MonoBehaviour
{
    public int numero;
    public string tipoCarta;
    public string rareza;
    public bool unica; // Nuevo campo booleano para indicar si la carta es única
    private int contador; // Contador para la carta
    public Sprite imagenCarta; // Nuevo campo para la imagen

    // Propiedad para acceder y gestionar el contador
    public int Contador
    {
        get { return contador; }
        set
        {
            contador = Mathf.Clamp(value, 0, unica ? 1 : 3); // Limitar según la regla
            ActualizarContadorUI();
        }
    }

    // Referencia al componente de texto para mostrar el contador
    public TextMeshProUGUI contadorText;

    void Start()
    {
        // Obtener el componente de texto para el contador
        contadorText = GetComponentInChildren<TextMeshProUGUI>();
        ActualizarContadorUI(); // Actualizar la UI al inicio
    }

    void ActualizarContadorUI()
    {
        // Mostrar el contador en el texto y cambiar el color a verde si es mayor que cero
        if (contador > 0)
        {
            contadorText.text = contador.ToString();
            contadorText.color = Color.green;
            contadorText.gameObject.SetActive(true); // Hacer visible el contador
        }
        else
        {
            contadorText.gameObject.SetActive(false); // Hacer invisible el contador
        }
    }

    // Puedes agregar más propiedades y métodos aquí según sea necesario
}

