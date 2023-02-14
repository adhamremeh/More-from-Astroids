﻿using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sounds[] audios;

    void Awake()
    {
        foreach (Sounds s in audios)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

            s.source.loop = s.loop;

        }
    }

    public void playsound(string clipname)
    {
        Sounds s = Array.Find(audios, sound => sound.name == clipname);
        s.source.Play();
    }

    public void stopsound(string clipname)
    {
        Sounds s = Array.Find(audios, sound => sound.name == clipname);
        s.source.Stop();
    }
}
