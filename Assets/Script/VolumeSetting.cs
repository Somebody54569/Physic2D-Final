using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSetting : MonoBehaviour
{
   [SerializeField] private AudioMixer mixer;
   [SerializeField] private Slider musicSlider;
   [SerializeField] private Slider SFXSlider;
   private void Start()
   {
      if (PlayerPrefs.HasKey("musicVolume"))
      {
         LoadVolume();
      }
      else
      {
         SetMusicVolume();
         SetSFXVolume();
      }
   }

   public void SetMusicVolume()
   {
      float volume = musicSlider.value;
      mixer.SetFloat("music", Mathf.Log10(volume) * 20);
      PlayerPrefs.SetFloat("musicVolume", volume);
   }
   
   public void SetSFXVolume()
   {
      float volume = SFXSlider.value;
      mixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
      PlayerPrefs.SetFloat("SFXVolume", volume);
   }

   void LoadVolume()
   {
      musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
      SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
      
      SetMusicVolume();
      SetSFXVolume();
   }
}
