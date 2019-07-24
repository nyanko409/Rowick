using UnityEngine;
using UnityEngine.UI;

public class ChargeBar : MonoBehaviour
{
    public PointCharge pointCharge;

    public PlayerValue character;
    public Image meterImage;
    public Text chargeText;

    float maxUltraCharge;
    
    // Start is called before the first frame update
    void Start()
    {
        maxUltraCharge = character.maxUltraCharge;
    }

    // Update is called once per frame
    void Update()
    {
        if (character != null)
        {
            meterImage.fillAmount = pointCharge.value / maxUltraCharge;
            chargeText.text = "ULTRA:" + (int)(meterImage.fillAmount * 100) + "%";
        }
    }
}
