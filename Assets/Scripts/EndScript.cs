using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    [SerializeField] private AudioSource endSooundEffect;
    public void endGame()
    {
        endSooundEffect.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
