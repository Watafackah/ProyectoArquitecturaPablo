using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooling : MonoBehaviour
{
    float bulletSpeed = 500; // Asignamos velocidad inicial a la bala.
    public GameObject bullet; // Declaramos el objeto "bala" de manera pública, donde añadiremos el prefab.
    public GameObject PrefabSpot; // Lugar donde aparecerán las balas.
    List<GameObject> bulletList; // Lista donde guardaremos las balas.

    void Start()
    {
        bulletList = new List<GameObject>(); // Inicializamos la lista de las balas para almacenarlas y llamarlas cuando se requiera.

        for(int i = 0; i <10; i++) // Creamos un bucle donde crea la bala, la desactiva y añade a la lista previamente creada.
        {   GameObject bulletObj = (GameObject)Instantiate(bullet);
            bulletObj.SetActive(false);
            bulletList.Add(bulletObj);}
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)) // Cuando pulsas click izquierdo, inicia la función de disparo.
        {Fire();}
    }

    void Fire()
    {
        for(int i = 0; i < bulletList.Count; i++) // Creamos una variable i = 0, para que desde 0 a el numero de balas máximo, nos active la bala y la coloque en la posición deseada, tambien empuja el rigidbody.
        {
            if (!bulletList[i].activeInHierarchy)
            {   bulletList[i].transform.position = transform.position;
                bulletList[i].transform.rotation = transform.rotation.normalized;
                bulletList[i].SetActive(true);
                Rigidbody tempRigidBodyBullet = bulletList[i].GetComponent<Rigidbody>();
                tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward);
                break;}
            else // Cuando no se están creado balas, se van desactivando en orden.
            {StartCoroutine(DesactiveBullets());}
        }
    }

    IEnumerator DesactiveBullets() // Desactiva las balas en ordes ascendiente, cada dos segundos.
    {
        for (int i = 0; i < bulletList.Count; i++)
        {bulletList[i].SetActive(false);
            yield return new WaitForSeconds(0.2f);}   
    }
}
