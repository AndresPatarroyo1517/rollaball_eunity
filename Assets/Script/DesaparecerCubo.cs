using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class DesaparecerCubo : MonoBehaviour
{
    [Header("Configuración")]
    [SerializeField] private float tiempoDesaparicion = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Desaparecer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Desaparecer()
    {
        yield return new WaitForSeconds(tiempoDesaparicion);
        gameObject.SetActive(false);
    }
    
}
