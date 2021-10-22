using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botoes : MonoBehaviour
{
    [SerializeField] Image ComSom;
    [SerializeField] Image SemSom;
    private bool Mutado = false;

    private void Start()
    {
        SemSom.enabled = false;
    }

    public void Som()
    {
        if (Mutado == false)
        {
            Mutado = true;
            AudioListener.pause = true;
            ComSom.enabled = false;
            SemSom.enabled = true;
        }
        else
        {
            Mutado = false;
            AudioListener.pause = false;
            ComSom.enabled = true;
            SemSom.enabled = false;
        }
    }

    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    public void Sair()
    {
        Application.Quit();
    }
}
