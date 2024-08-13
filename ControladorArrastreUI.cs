using UnityEngine;
using UnityEngine.EventSystems;

public class ControladorArrastreUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Canvas lienzo;
    private RectTransform rectTransform;
    private CanvasGroup grupoCanvas;
    public Transform[] zonasAnclaje; // Las zonas donde deseas anclar el objeto

    private void Awake()
    {
        lienzo = GetComponentInParent<Canvas>();
        rectTransform = GetComponent<RectTransform>();
        grupoCanvas = GetComponent<CanvasGroup>();
        if (grupoCanvas == null)
        {
            grupoCanvas = gameObject.AddComponent<CanvasGroup>();
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        grupoCanvas.alpha = 0.6f; // Opcional: hace que la imagen sea semi-transparente durante el arrastre
        grupoCanvas.blocksRaycasts = false; // Permite que la imagen sea ignorada por los raycasts durante el arrastre
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / lienzo.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        grupoCanvas.alpha = 1f; // Restaura la opacidad completa
        grupoCanvas.blocksRaycasts = true; // Rehabilita los raycasts

        foreach (Transform zona in zonasAnclaje)
        {
            if (RectTransformUtility.RectangleContainsScreenPoint(
                zona.GetComponent<RectTransform>(), Input.mousePosition, lienzo.worldCamera))
            {
                rectTransform.anchoredPosition = zona.GetComponent<RectTransform>().anchoredPosition;
                break;
            }
        }
    }
}
