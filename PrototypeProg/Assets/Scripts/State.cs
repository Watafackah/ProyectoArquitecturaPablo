using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public GameObject cube; // Declaramos el GameObject que sufrira los cambios
    public float speed = 1f; // Declaramos la velocidad a la cual caerá el cubo.

    private void Update()
    {
        float step = speed * Time.deltaTime; // Declaramos la operacion de velocidad por tiempo.
        transform.position = Vector3.MoveTowards(transform.position, cube.transform.position, step); // Transformamos la posicion del objeto.

        if (Input.GetKeyDown(KeyCode.Mouse1)) // Se activa dando click derecho, llamando a la función.
        {
            buttonOnClick();
        }
    }

    void buttonOnClick() // Cuando da click activa el componente Kinematico, si ya estaba activado, lo desactiva.
    {
        
        Rigidbody cubeRigidbody = cube.GetComponent<Rigidbody>();
        if (cubeRigidbody.isKinematic == false)
            cubeRigidbody.isKinematic = true;
        else
            cubeRigidbody.isKinematic = false;
    }
}
