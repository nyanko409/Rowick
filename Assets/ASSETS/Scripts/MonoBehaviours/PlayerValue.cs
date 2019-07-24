using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerValue : MonoBehaviour
{

    public PointCharge ultraCharge;
    public float maxUltraCharge;
    public float startingUltraCharge;
    public ChargeBar chargeBarPrefab;

    public GameObject ultraSkillObj1;
    public GameObject ultraSkillObj2;
    ChargeBar chargeBar;

    float waitTime = 2.0f;
    float timer = 0.0f;
    bool UltraSkillActive = false;

    // Start is called before the first frame update
    void Start()
    {
        ultraCharge.value = startingUltraCharge;
        chargeBar = Instantiate(chargeBarPrefab);
        chargeBar.character = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) || Input.GetMouseButtonDown(1))
        {
            if (ultraCharge.value >= maxUltraCharge)
            {
                UltraSkillActive = true;
                ultraCharge.value = 0;
                gameObject.GetComponent<Life>().health++;

                //setActive true
                ultraSkillObj1.SetActive(true);
                ultraSkillObj2.SetActive(true);
            }

        }

        if (UltraSkillActive)
        {
            timer += Time.deltaTime;
            if (timer >= waitTime)
            {
                UltraSkillActive = false;
                //setActive false
                ultraSkillObj1.SetActive(false);
                ultraSkillObj2.SetActive(false);
                timer = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            gameObject.GetComponent<Life>().health--;
            if (gameObject.GetComponent<Life>().health <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }


}
