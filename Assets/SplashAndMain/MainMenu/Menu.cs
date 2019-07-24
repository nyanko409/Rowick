using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour
{
    public AudioClip clip;

    AudioSource source;
    public PointCharge point;
    public PointCharge ultraCharge;


    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = clip;
        point.value = 0;
        ultraCharge.value = 0;
    }

    public void GameStart()
    {
        source.Play();
        StartCoroutine("Wait");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(.5f);
        SceneManager.LoadScene("game");
    }

    public void GameQuit()
    {
        source.Play();
        Application.Quit();
    }
}
