using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;



public class StartMenu : MonoBehaviour
{
    [SerializeField] private AudioSource startSooundEffect;
    public void StartGame()
    {
        startSooundEffect.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
