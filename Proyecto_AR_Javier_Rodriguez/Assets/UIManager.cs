using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class UIManager : MonoBehaviour
{
    [Header("Paneles Principales")]
    // Elemento que se muestra al inicio y luego desaparece.
    public GameObject panelBienvenida;
    // El panel que contiene toda la interfaz de instrucciones.
    public GameObject panelInstrucciones;

    [Header("Controles y Botones Comunes")]
    // Botones de navegación, aunque solo se usan para la referencia del GO.
    public Button btnClose;
    public Button btnFlechaD; // Botón Flecha Derecha
    public Button btnFlechaI; // Botón Flecha Izquierda

    [Header("Elementos de la Vista 1")]
    public GameObject billConLapara;
    public GameObject libro;
    public GameObject instrucciones1;

    [Header("Elementos de la Vista 2")]
    public GameObject celular; // Nota: Usando el nombre 'Celualr' de la jerarquía
    public GameObject anguloLimit1_1; // Referencia a AnguloLimit1
    public GameObject anguloLimit1_2; // Referencia a AnguloLimit1 (1)
    public GameObject instrucciones2;

    // Enumeración para rastrear la vista actual
    private enum CurrentView { Vista1, Vista2 }
    private CurrentView currentView;

    // --- MÉTODOS DE INICIALIZACIÓN ---

    void Start()
    {
        // 1. Ocultar todos los elementos y mostrar solo el PanelBienvenida al inicio.
        HideAllContent();
        panelBienvenida.SetActive(true);

        // 2. Asignar las funciones a los botones
        // Se asume que Close es el botón que cierra la interfaz.
        btnClose.onClick.AddListener(OnCloseClicked);
        btnFlechaD.onClick.AddListener(OnFlechaDClicked);
        btnFlechaI.onClick.AddListener(OnFlechaIClicked);   

        // 3. Iniciar la secuencia de bienvenida.
        StartCoroutine(StartWelcomeSequence());
    }

    /// <summary>
    /// Corrutina para manejar el tiempo de espera de la pantalla de bienvenida.
    /// </summary>
    IEnumerator StartWelcomeSequence()
    {
        // Esperar 3 segundos.
        yield return new WaitForSeconds(3f);

        // Desaparece el panel de bienvenida.
        panelBienvenida.SetActive(false);

        // Muestra la primera vista.
        ShowView1();
    }

    /// <summary>
    /// Oculta todos los elementos de las vistas (para asegurar un estado limpio).
    /// </summary>
    private void HideAllContent()
    {
        panelInstrucciones.SetActive(false);
        panelBienvenida.SetActive(false);

        // Ocultar elementos de ambas vistas (1 y 2)
        billConLapara.SetActive(false);
        libro.SetActive(false);
        instrucciones1.SetActive(false);

        celular.SetActive(false);
        anguloLimit1_1.SetActive(false);
        anguloLimit1_2.SetActive(false);
        instrucciones2.SetActive(false);

        // Los botones se activarán con panelInstrucciones si están dentro.
        // Si están fuera, los activamos aquí:
        btnClose.gameObject.SetActive(false);
        btnFlechaD.gameObject.SetActive(false);
        btnFlechaI.gameObject.SetActive(false);
    }

    // --- GESTIÓN DE VISTAS ---

    private void ShowView1()
    {
        

        // Ocultar elementos de Vista 2
        celular.SetActive(false);
        anguloLimit1_1.SetActive(false);
        anguloLimit1_2.SetActive(false);
        instrucciones2.SetActive(false);

        // Mostrar elementos de Vista 1
        billConLapara.SetActive(true);
        libro.SetActive(true);
        instrucciones1.SetActive(true);
        // Activar el contenedor principal y controles
        panelInstrucciones.SetActive(true);
        btnClose.gameObject.SetActive(true);
        btnFlechaD.gameObject.SetActive(true);
        btnFlechaI.gameObject.SetActive(true);

        // Establecer estado de la vista
        currentView = CurrentView.Vista1;

        Debug.Log("Cambiando a Vista 1");
    }

    private void ShowView2()
    {
        // Ocultar elementos de Vista 1
        billConLapara.SetActive(false);
        
        instrucciones1.SetActive(false);

        // Mostrar elementos de Vista 2
        celular.SetActive(true);
        anguloLimit1_1.SetActive(true);
        anguloLimit1_2.SetActive(true);
        instrucciones2.SetActive(true);

        // Establecer estado de la vista
        currentView = CurrentView.Vista2;

        Debug.Log("Cambiando a Vista 2");
    }

    // --- MÉTODOS DE BOTONES ---

    public void OnFlechaDClicked()
    {
        if (currentView == CurrentView.Vista1)
        {
            // Transición de Vista 1 a Vista 2
            ShowView2();
        }
        else
        {
            // Estando en Vista 2, no pasa nada (según tu requerimiento)
            Debug.Log("Ya estás en la última vista.");
        }
    }

    public void OnFlechaIClicked()
    {
        if (currentView == CurrentView.Vista2)
        {
            // Transición de Vista 2 a Vista 1
            ShowView1();
        }
        else
        {
            // Estando en Vista 1, no pasa nada (según tu requerimiento)
            Debug.Log("Ya estás en la primera vista.");
        }
    }

    public void OnCloseClicked()
    {
        // Desactiva el Canvas (el Game Object padre de la UI) para cerrar todo.
        // Asumiendo que este script está en un objeto dentro del Canvas o en el Canvas mismo.
        // Si quieres cerrar solo la interfaz de instrucciones, usa 'panelInstrucciones.SetActive(false);'

        // Cierra todo el Canvas:
        transform.root.gameObject.SetActive(false);

        Debug.Log("Cerrando toda la interfaz.");
    }
}