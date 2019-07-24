using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOnMouseOver : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] Image arrow1;
    [SerializeField] Image arrow2;

    public void OnPointerEnter(PointerEventData eventData)
    {
        print(eventData.pointerEnter.transform.parent.name);

        if(eventData.pointerEnter.transform.parent.name == "Start")
        {
            arrow1.gameObject.SetActive(true);
            arrow2.gameObject.SetActive(false);
        }
        else if (eventData.pointerEnter.transform.parent.name == "Quit")
        {
            arrow1.gameObject.SetActive(false);
            arrow2.gameObject.SetActive(true);
        }
    }
}
