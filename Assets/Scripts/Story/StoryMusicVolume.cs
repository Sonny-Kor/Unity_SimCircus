using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryMusicVolume : MonoBehaviour
{
    public AudioSource music;
    private float vol;
    // Start is called before the first frame update
    void Start()
    {
        vol = PlayerPrefs.GetFloat("vol");
        music.volume = vol;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
