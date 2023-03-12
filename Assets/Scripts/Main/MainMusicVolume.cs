using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMusicVolume : MonoBehaviour
{
    public AudioSource music;
    public AudioSource effect;
    public Slider volume_control;
    public Slider effect_control;

    private float vol = 0.129f;
    private float eff = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        vol = PlayerPrefs.GetFloat("vol");
        volume_control.value = vol;
        music.volume = volume_control.value;

        eff = PlayerPrefs.GetFloat("eff");
        effect_control.value = eff;
        effect.volume = effect_control.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolumeSlider()
    {
        music.volume = volume_control.value;

        vol = volume_control.value;
        PlayerPrefs.SetFloat("vol", vol);
    }

    public void EffectSlider()
    {
        effect.volume = effect_control.value;

        eff = effect_control.value;
        PlayerPrefs.SetFloat("eff", eff);
    }
}
