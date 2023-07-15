using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tiempo : MonoBehaviour
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
        puntos += Time.deltaTime;
        textMeshProUGUI.text = puntos.ToString("0");
    }
}
