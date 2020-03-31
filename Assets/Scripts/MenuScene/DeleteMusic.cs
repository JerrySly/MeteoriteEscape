using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMusic : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private ToMenu button;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        _audioSource = (AudioSource)FindObjectOfType(System.Type.GetType("AudioSource"));
    }

    // Update is called once per frame
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
