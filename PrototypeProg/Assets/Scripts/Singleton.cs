using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance { get; private set; } // Declaramos el singleton y pedimos un valor.

    public int Value; // Declaramos el valor que cambiará al realizar la accion

    private void Awake()
    {
        if(Instance == null) // Revisa si existe previamente.
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // No destruye el objeto al cargar la nueva escena.
        }
        else
        {
            Destroy(gameObject); // Destruye el objeto en caso de ya estar inicializado.
        }
    }


}
