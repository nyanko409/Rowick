using UnityEngine;

public class Bullet : MonoBehaviour
{

    public PlayerValue playerValue;
    public static Bullet instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        playerValue = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerValue>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("GAIN"+other.name);

        if (other.gameObject.CompareTag("CanBePickedUp"))
        {
            Item hitObject = other.gameObject.GetComponent<Consumable>().item;
            if (hitObject != null)
            {
                bool shouldDisappear = false;

                switch (hitObject.itemType)
                {
                    case Item.ItemType.HEALTH:
                        shouldDisappear = GainHealth(hitObject.quantity);
                        break;
                    case Item.ItemType.TOOL:

                        shouldDisappear = true;
                        break;
                    default:
                        break;
                }

                if (shouldDisappear)
                {
                    other.gameObject.SetActive(false);
                }
            }
        }
    }

    public bool GainHealth(int amount)
    {
        if (Life.instance.health < Life.instance.numOfLife)
        {

            Life.instance.health++;
            return true;
        }
        return false;
    }

    public bool AdjustChargePoints(int amount)
    {
        if (playerValue.ultraCharge.value < playerValue.maxUltraCharge)
        {
            playerValue.ultraCharge.value = playerValue.ultraCharge.value + amount;
            return true;
        }

        return false;
    }
}
