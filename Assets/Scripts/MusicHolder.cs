using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class MusicHolder: MonoBehaviour
{
    [SerializeField]private  AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        _audioSource.Play();   
    }

}
