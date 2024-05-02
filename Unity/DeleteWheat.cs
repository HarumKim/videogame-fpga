using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteWheat : MonoBehaviour
{
    public Text wheatCountText; // Referencia al elemento de texto para mostrar la cantidad de ma�z
    public Text seedsCountText; // Referencia al elemento de texto para mostrar la cantidad de semillas
    public static int wheatCount = 0; // Contador de la cantidad de ma�z cosechado
    public static int seedsCount = 0;

    private GameObject currentCorn = null; // Referencia al objeto de ma�z con el que se ha colisionado
    private ToolSelection farmingToolSelector; // Referencia al script de selecci�n de herramienta

    public UIController action;

    private GameManager gameManager; // Referencia al GameManager

    private void Start()
    {
        wheatCountText.text = "Wheat: " + wheatCount.ToString();
        seedsCountText.text = "Seeds: " + seedsCount.ToString();

        // Obtener referencia al script FarmingToolSelector
        farmingToolSelector = FindObjectOfType<ToolSelection>();

        // Obtener referencia al GameManager
        gameManager = FindObjectOfType<GameManager>(); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wheat")) // Verifica si colision� con un objeto de ma�z
        {
            currentCorn = collision.gameObject; // Almacena la referencia al ma�z colisionado
            gameManager.AddWheat(collision.gameObject); // Informa al GameManager sobre el trigo colisionado
        }

    
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wheat")) // Verifica si sali� de la colisi�n con un objeto de ma�z
        {
            currentCorn = null; // Borra la referencia al ma�z colisionado
        }


    }
    private void Update()
    {
        if (farmingToolSelector.currentTool == ToolSelection.FarmingTool.Harvest && currentCorn != null && ((Input.GetKeyDown(KeyCode.Space)) || action.HarvestAction == 1))
        {
            HarvestCorn(currentCorn);
            currentCorn = null; // Borra la referencia despu�s de interactuar con el ma�z
        }
    }

    private void HarvestCorn(GameObject cornObject)
    {
        // Destruir el objeto de ma�z espec�fico al cosecharlo (quitar el sprite)
        Destroy(cornObject); // Destruye el objeto de ma�z con el que se colision�
        PlayerPrefs.SetInt("WheatHarvested", 1);

        // Aumentar la cantidad de ma�z y semillas
        wheatCount++;
        seedsCount++;

        // Actualizar la interfaz de usuario para mostrar la cantidad actual de ma�z y semillas
        UpdateCountUI();
    }


    public void UpdateCountUI()
    {
        // Actualizar el texto en la interfaz de usuario para mostrar la cantidad actual de ma�z y semillas
        if (wheatCountText != null && seedsCountText != null)
        {
            wheatCountText.text = "Wheat: " + wheatCount.ToString();
            seedsCountText.text = "Seeds: " + seedsCount.ToString();
        }
    }
}
