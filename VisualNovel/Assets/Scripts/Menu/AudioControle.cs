using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioControle : MonoBehaviour
{
    public  List<AudioSource> musica, ambiente;
    public Slider sliderM,sliderA;
    public static float volumeM, volumeA;
    public static int indexMusic;
    void Start()
    {
        sliderM.value = volumeM;
        sliderA.value = volumeA;
        StartCoroutine(PlayMusic(musica));

        
    }
    public void Volume(int op)
    {
        if(op==0)
        {
            foreach (AudioSource som in musica)
            {
                som.volume = sliderM.value;
                volumeM = som.volume;

            }
        }
        if (op == 1)
        {
            foreach (AudioSource som in ambiente)
            {
                som.volume = sliderA.value;
                volumeA = som.volume;

            }
        }

    }

  

    IEnumerator PlayMusic(List<AudioSource> music)
    {
        while(true)
        {
            music[indexMusic].Play();
            yield return new WaitForSeconds(music[indexMusic].clip.length);
            indexMusic++;
            if(indexMusic>=musica.Count) 
            {
                indexMusic = 0;
            }
        }

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
