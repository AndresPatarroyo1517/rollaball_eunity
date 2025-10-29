using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject Player;
    public float shootTime = 1f;
    public float range = 100f;
    float timer;
    Ray shootRay;
    RaycastHit shootHit;
    int shootableMask;
    LineRenderer gunLine;
    Light gunLight;
    float effectsDisplayTime = 1.2f;

    void Awake(){
        shootableMask = LayerMask.GetMask("Shootable");
        gunLight = GetComponent<Light>();
        gunLine = GetComponent<LineRenderer>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= shootTime * effectsDisplayTime){
            DisableEffect();
        }
    }

    void Shoot(){
        Vector3 ubicacion = new Vector3(Player.transform.position.x, Player.transform.position.y + 1.1f, Player.transform.position.z);

        timer = 0f;
        gunLine.enabled = true;
        gunLight.enabled = true;
        shootRay.origin = ubicacion;
        shootRay.direction = transform.forward;
        gunLine.SetPosition(0, ubicacion);

        if (Physics.Raycast(shootRay, out shootHit, range, shootableMask))
        {
            Destroy(shootHit.collider.gameObject);
            gunLine.SetPosition(1, shootHit.point);
        }
        else
        {
            Debug.Log("No se impacto con ningun objeto");
            gunLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
        }
    }

    public void DisableEffect(){
         gunLine.enabled = false;
        gunLight.enabled = false;
    }
    
}
