using UnityEngine;
using UnityEngine.UI;

public class MoveArrow : MonoBehaviour
{
    [SerializeField] Image arrow1;
    [SerializeField] Image arrow2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            arrow1.gameObject.SetActive(!arrow1.gameObject.activeSelf);
            arrow2.gameObject.SetActive(!arrow2.gameObject.activeSelf);
        }
    }
}
