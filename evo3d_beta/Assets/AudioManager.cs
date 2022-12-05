using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class AudioManager : MonoBehaviour
{
 
    public TextMeshProUGUI SongName;
    public AudioSource SongSource;
    public AudioClip[] AllSongs;
 
    void Start()
    {
        playRandomMusic();
    }
 
    void Update()
    {
        if (!SongSource.isPlaying)
            playRandomMusic();
    }
 
    void playRandomMusic()
    {
        SongSource.clip = AllSongs[Random.Range(0, AllSongs.Length)];
        SongSource.Play();
        SongName.text = ("Musica actual: " + SongSource.clip.name);
    }
}