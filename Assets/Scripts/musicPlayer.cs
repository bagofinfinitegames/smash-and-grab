using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPlayer : MonoBehaviour {
    public AudioClip[] songs;
    public AudioSource source;
    public int currentSong = 0;

    void Start () {
        if(source == null) {
            source = GetComponent<AudioSource>();
        }
        shuffleSongs();
        playCurrentSong();
    }

    void Update () {
        //AudioSource .isPlaying .Play .clip
        if (!source.isPlaying) {
            if(currentSong < songs.Length - 1) {
                currentSong += 1;
            } else {
                shuffleSongs();
                currentSong = 0;
            }

            playCurrentSong();
        }
	}

    void playCurrentSong() {
        source.clip = songs[currentSong];
        source.Play();
    }

    void shuffleSongs() {
        currentSong = 0;
        for(int i = 0; i < songs.Length; i++) {
            int rand = Random.Range(0, songs.Length - 1);
            AudioClip tmp = songs[i];
            songs[i] = songs[rand];
            songs[rand] = tmp;
        }
    }
}
