using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navegar : MonoBehaviour
{
    // Start is called before the first frame update
    public void CarregarFase1()
    {


        //método inicia uma nova cena
        SceneManager.LoadScene("colision");
    }
    public void Sair()
    {
        Application.Quit();
    }
}
