using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{

    private float puntos;
    private TextMeshProUGUI textMeshProUGUI;

    // Start is called before the first frame update
    private void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>(); 
    }

    // Update is called once per frame
    private void Update()
    {
        textMeshProUGUI.text = puntos.ToString("0");
    }

    public void SumarPuntos(float puntaje) { 
        puntos += puntaje;
    }
}
