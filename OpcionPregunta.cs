using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class OpcionPregunta : MonoBehaviour
{
    public Text textMeshPro;
    public UnityEngine.UI.Button btnCorrecto;
    public UnityEngine.UI.Button btninCorrecto;
    public UnityEngine.UI.Button btnRegresoMenu;

    public void respuestaCorrecta()
    {
        Debug.Log("Haz respondidio correctamente.");
        textMeshPro.gameObject.SetActive(true);
        btninCorrecto.gameObject.SetActive(false);
        btnRegresoMenu.gameObject.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); el + 1 indica que se mueva a la siguiente Scene.
    }

    public void respuestaIncorrecta()
    {
        Debug.Log("Que mala suerte, esa es la respuesta incorrecta :(.");
        textMeshPro.text = "Que mala suerte, esa es la respuesta incorrecta :(.";
        textMeshPro.gameObject.SetActive(true);
        btnCorrecto.gameObject.SetActive(false);
        btnRegresoMenu.gameObject.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); el + 1 indica que se mueva a la siguiente Scene.
    }

    public void regresarAlMenu() {
        SceneManager.LoadScene(0);
    }
}
