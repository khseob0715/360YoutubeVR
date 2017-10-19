using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class VideoController : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        MovieTexture MOVIE_TEXTURE = ((MovieTexture)GetComponent<Renderer>().material.mainTexture);
               
        AudioSource movieAudio = GetComponent<AudioSource>();
        movieAudio.clip = MOVIE_TEXTURE.audioClip;
        
        MOVIE_TEXTURE.Play();
        movieAudio.Play();
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}
