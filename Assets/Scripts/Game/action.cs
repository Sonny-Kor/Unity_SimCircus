using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action : MonoBehaviour
{
    public enum Type { Tiger, Bear, Chimpanze, Dog, Elephant, Horse, lion };
    public Type type;
    public Animator anim;
    private AudioSource audio2;
    public AudioClip backMusic;
    public AudioClip playMusic;

    private bool music_on;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Bool", false);
        audio2 = GameObject.Find("Mehandi Circus Bgm").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void moving()
    {
        Invoke("animstart", 1);
    }

    public void stop()
    {
        Invoke("animstop", 3);
    }

    void animstop()
    {
        anim.SetBool("Bool", false);
        gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "middle";
    }

    public void animstart()
    {
        Debug.Log("here");
        anim.SetBool("Bool", true);
    }
    public void PlayMusic()
    {
        audio2.clip = playMusic;
        audio2.Play();
    }
    public void PlaybackMusic()
    {
        audio2.clip = backMusic;
        audio2.Play();
    }


    public void Play()
    {
        Invoke("PlayMusic",1.0f);
        Invoke("PlaybackMusic", 3.0f);
    }
}