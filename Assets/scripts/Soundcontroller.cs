using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soundcontroller : MonoBehaviour {

	AudioSource audio;
	public Slider soundSlider;
	void Start () 
	{
		audio = GameObject.FindWithTag("audio").GetComponent<AudioSource>();
		soundSlider.value = audio.volume;
	}
	
	
	void Update () 
	{
		
		audio.volume = soundSlider.value;
	}
}
