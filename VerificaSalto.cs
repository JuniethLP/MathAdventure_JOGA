using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificaSalto : MonoBehaviour
{

    public static bool estaEnPiso;

    private void OnTriggerEnter2D(Collider2D other)
    {
        estaEnPiso = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        estaEnPiso = false;
    }
}
