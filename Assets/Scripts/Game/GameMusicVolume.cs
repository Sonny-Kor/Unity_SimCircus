using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMusicVolume : MonoBehaviour
{
    public AudioSource g_music;
    public AudioSource g_effect;
    public Slider g_volume_control;
    public Slider g_effect_control;

    private float g_vol;
    private float g_eff;
    // Start is called before the first frame update
    void Start()
    {
        g_vol = PlayerPrefs.GetFloat("vol");
        g_volume_control.value = g_vol;
        g_music.volume = g_volume_control.value;

        g_eff = PlayerPrefs.GetFloat("eff");
        g_effect_control.value = g_eff;
        g_effect.volume = g_effect_control.value;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void VolumeSlider()
    {
        g_music.volume = g_volume_control.value;

        g_vol = g_volume_control.value;
        PlayerPrefs.SetFloat("vol", g_vol);
    }

    public void EffectSlider()
    {
        g_effect.volume = g_effect_control.value;

        g_eff = g_effect_control.value;
        PlayerPrefs.SetFloat("eff", g_eff);
    }
}
