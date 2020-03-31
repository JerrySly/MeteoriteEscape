using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public   class MusicHolder: MonoBehaviour
{
    public static MusicHolder Instance;
    [SerializeField]private  AudioSource _audioSource;
    [SerializeField] private ToMenu button;

    MusicHolder()
    {

    }
    public static MusicHolder GetInstance()
    {
        if (Instance == null)
            Instance = new MusicHolder();
        return Instance;
    }
    private void Awake()
    {

        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        if (Instance == null)
        {
            _audioSource.Play();
            GetInstance();
        }
        
    }
    private void Update()
    {
        SearchButton();
    }
    private void SearchButton()
    {
        button = (ToMenu)FindObjectOfType(System.Type.GetType("ToMenu"));
        button.OnButtonToMusic += StopPlaying;
    }
    private void StopPlaying()
    {
        _audioSource.Stop();
        Destroy(this);
    }

}
