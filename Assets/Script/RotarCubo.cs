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
    
    public void MoverX(float value){
        transform.position = new Vector3(value, transform.position.y, transform.position.z);
    }

    public void MoverY(float value){
        transform.position = new Vector3(transform.position.x, 1+value, transform.position.z);
    }

    public void MoverZ(float value){
        transform.position = new Vector3(transform.position.x, transform.position.y, value);
    }


    public void Reset(){
        transform.position = new Vector3(0,1,0);
        transform.localScale = new Vector3(2, 2, 2);
        material.color = Color.yellow;
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
