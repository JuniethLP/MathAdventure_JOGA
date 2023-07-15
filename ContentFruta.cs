using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContentFruta : MonoBehaviour
{

    public Text nivelCompletado;

    private void Update()
    {
        obtieneCantidadFruta();
    }

    public void obtieneCantidadFruta() {


        if (gameObject.transform.childCount == 0)
        {
            Debug.Log("Haz recolectado todas la frutas. " + transform.childCount);
            nivelCompletado.gameObject.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //el + 1 indica que se mueva a la siguiente Scene.
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
