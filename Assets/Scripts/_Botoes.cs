using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Botoes : MonoBehaviour
{
    public void Reload()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
