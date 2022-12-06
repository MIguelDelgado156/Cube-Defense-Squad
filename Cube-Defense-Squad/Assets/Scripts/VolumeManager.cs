using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float V;

    void Awake()
    {
        V = StaticVars.volume;
        AudioListener.volume = V;
        this.GetComponent<Slider>().value = V;
    }

    void Update()
    {
        this.GetComponent<Slider>().value = StaticVars.volume;
    }

    public void UpdateVolume(float volume)
    {
        StaticVars.volume = volume;
        AudioListener.volume = volume;
        SaveSystem.Save();
    }
}
