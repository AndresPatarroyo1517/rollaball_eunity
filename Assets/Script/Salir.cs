using UnityEngine;
using TMPro;

public class Salir : MonoBehaviour
{
    public GameObject contenedor;
    public TextMeshProUGUI mensajeSalir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    mensajeSalir.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SalirApp(){
        contenedor.SetActive(true);
        mensajeSalir.text = "Gracias por jugar";
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Aplication.Quit();
        #endif
    }
}
