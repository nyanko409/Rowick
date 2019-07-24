using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayBGM : MonoBehaviour
{
    public AudioClip bgmClip;

	AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = bgmClip;
        source.loop = true;

        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
