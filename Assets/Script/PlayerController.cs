using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;
public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int contador;
    private Rigidbody rb;
    public float speed;
    public float jumpForce = 5f;
    private bool isGrounded = true;
    public TextMeshProUGUI puntajeGUI;
    public GameObject mensajeGanar;

    public Transform particles;
    private ParticleSystem particleSystem;
    private Vector3 position;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        SetCountText();
        mensajeGanar.SetActive(false);
        particleSystem = particles.GetComponent<ParticleSystem>();
        particleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontalMove, 0.0f, verticalMove);
        rb.AddForce(move * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Recolectable"))
        {
            other.gameObject.SetActive(false);
            contador += 1;
            SetCountText();
        }
    }
    
    void SetCountText()
    {
        puntajeGUI.text = "Puntaje: " + contador.ToString();
        if (contador >= 30)
        {
            mensajeGanar.SetActive(true);
        }
    }
}
