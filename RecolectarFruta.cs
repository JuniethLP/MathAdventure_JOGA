using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolectarFruta : MonoBehaviour
{

    [SerializeField] private float cantPuntos;
    [SerializeField]private Puntuacion puntuacion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si la colisión contiene el tag de nombre player.
        if (collision.CompareTag("Player")) 
        {

            puntuacion.SumarPuntos(cantPuntos);

            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            FindObjectOfType<ContentFruta>().obtieneCantidadFruta();

            Destroy(gameObject, 0.5f);
        }
    }
}
