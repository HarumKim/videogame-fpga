using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brillo : MonoBehaviour
{
    public Slider slider;         // Referencia al Slider en el UI
    public Image panelBrillo;     // Referencia al panel cuyo brillo queremos cambiar
    private float sliderValue;    // Valor actual del Slider

    void Start()
    {
        // Obtener el valor almacenado en PlayerPrefs (si existe)
        sliderValue = PlayerPrefs.GetFloat("Brillo", 0.5f);
        slider.value = sliderValue;

        // Actualizar el color inicial del panel seg�n el valor del Slider
        UpdatePanelColor();
    }

    // M�todo para actualizar el color del panel seg�n el valor del Slider
    private void UpdatePanelColor()
    {
        // Calcular valores de brillo para el color negro y blanco
        float valorBlack = 1 - sliderValue;
        float valorWhite = sliderValue;

        // Asignar el color al panel seg�n el valor del Slider
        if (sliderValue < 0.5f)
        {
            panelBrillo.color = new Color(0, 0, 0, valorBlack);
        }
        else
        {
            panelBrillo.color = new Color(1, 1, 1, valorWhite);
        }
    }

    // M�todo llamado cuando se cambia el valor del Slider
    public void ChangeSlider(float valor)
    {
        sliderValue = valor;

        // Guardar el nuevo valor en PlayerPrefs
        PlayerPrefs.SetFloat("Brillo", sliderValue);

        // Actualizar el color del panel con el nuevo valor del Slider
        UpdatePanelColor();
    }
}
