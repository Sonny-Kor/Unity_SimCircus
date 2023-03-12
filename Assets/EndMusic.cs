using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMusic : MonoBehaviour
{
    public AudioSource audio2;
    public AudioClip backMusic;

    // Start is called before the first frame update
    void Start()
    {
        audio2.clip = backMusic;
        audio2.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
