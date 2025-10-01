using UnityEngine;

public class RotarCubo : MonoBehaviour
{
    Material material;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        material = GetComponent<Renderer> ().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotar(){
        transform.Rotate(new Vector3(45,45,45));
    }

    public void Escalar(float value){
        transform.localScale = new Vector3(value, value, value);
    }

    public void CambiarColor (int opcion){
        switch(opcion){
            case 0: 
            material.color = Color.black;
            break;
            case 1: 
            material.color = Color.green;
            break;
            case 2: 
            material.color = Color.blue;
            break;
        }
    }
}
