using UnityEngine;
using UnityEngine.UI;

public class AsignarSpriteInicial : MonoBehaviour
{
    public string nombreObjetoCarta = "007_Sir_Galahad";
    public string nombreCarpetaCartas = "Cartas";
    public Image ImagenCartaGrande;

    void Start()
    {
        Debug.LogError("Entramos a la función");
        // Buscar la carpeta Cartas en la jerarquía
        //Transform carpetaCartas = transform.Find(nombreCarpetaCartas);
        Transform carpetaCartas = GameObject.Find("/Cartas").transform;
        if (carpetaCartas == null)
        {
            Debug.LogError("No se encontró la carpeta 'Cartas' en la jerarquía.");
            return;
        }

        // Buscar el objeto Image llamado '007_Sir_Galahad' dentro de la carpeta Cartas
        Transform objetoCarta = carpetaCartas.Find(nombreObjetoCarta);
        if (objetoCarta == null)
        {
            Debug.LogError("No se encontró el objeto '" + nombreObjetoCarta + "' en la carpeta 'Cartas'.");
            return;
        }

        // Obtener el componente Carta del objeto encontrado
        Carta cartaComponente = objetoCarta.GetComponent<Carta>();
        if (cartaComponente == null)
        {
            Debug.LogError("El objeto '" + nombreObjetoCarta + "' no tiene un componente 'Carta'.");
            return;
        }

        // Asignar el sprite de imagenCarta al componente ImagenCartaGrande
        Debug.Log(cartaComponente.imagenCarta);
        ImagenCartaGrande.sprite = cartaComponente.imagenCarta;
        if (ImagenCartaGrande.sprite == null)
        {
            Debug.Log(ImagenCartaGrande.sprite);
        }
        
        Debug.Log("El sprite ha sido asignado correctamente a ImagenCartaGrande.");
    }
}

