using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenu : MonoBehaviour
{
    public event Action OnButtonToMusic;
   public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
        
    }
    public void DeleteMusic()
    {
        OnButtonToMusic?.Invoke();
    }
}
