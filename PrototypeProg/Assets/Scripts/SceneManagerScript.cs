using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    public Text ValueText;

    private void Start()
    {
        ValueText.text = Singleton.Instance.Value.ToString();
    }

    public void GoToFirstScene()
    {
        SceneManager.LoadScene("Primera");
        Singleton.Instance.Value++;
    }

    public void GoToSecondScene()
    {
        SceneManager.LoadScene("Segunda");
        Singleton.Instance.Value++;
    }
}
