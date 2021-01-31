using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    public Text ValueText; // Declaramos un texto donde contabilizaremos las acciones mediante singleton.

    private void Start()
    {
        ValueText.text = Singleton.Instance.Value.ToString(); // Convertimos el valor a String para mostrarlo.
    }

    public void GoToFirstScene()
    {
        SceneManager.LoadScene("Primera"); // Cargamos la primera escena y añadimos 1 a la cuenta.
        Singleton.Instance.Value++;
    }

    public void GoToSecondScene()
    {
        SceneManager.LoadScene("Segunda"); // Cargamos la segunda escena y añadimos 1 a la cuenta.
        Singleton.Instance.Value++;
    }
}
