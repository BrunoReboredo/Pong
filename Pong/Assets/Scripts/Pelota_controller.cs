using Unity.VisualScripting;
using UnityEngine;

public class Pelota_controller : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]float force;
    [SerializeField]const float angle_min= -1;
    [SerializeField]const float angle_max = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //obtener la referencia del objeto asociado
        //rb.AddForce(new Vector2 (1,1) * force, ForceMode2D.Impulse); // con esta linea la pelota siempre sale en la misma dirección.
        //hacer que salga aleatorio
        int direccionX = Random.Range(0, 2) == 0 ? -1 : 1;
        LanzamientoDePelota(direccionX);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //para comprobar q funciona las palas
    void OnCollisionEnter2D(Collision2D other){
        string tag = other.gameObject.tag;

            if (tag == "pala_dere" || tag == "pala_izqui"){
                Debug.Log("he colisionado");
            }
           // Debug.Log("he colisionado");
    }

    //se activa cuando la bola entra en contacto con los muros laterales (se ha marcado gol)
    void OnTriggerEnter2D (Collider2D other){
        Debug.Log ("GOl "+ other.tag);
    }

    //Hace un random para elegir el angulo de lanzamiento de la pelota. Eje X e Y
    void LanzamientoDePelota(int direccionX){
        float angulo  = Random.Range(angle_min, angle_max);
        float x = Mathf.Cos(angulo) * direccionX;
        // hace q si sale 0 sea -1 (para abajo) y si sale uno sale para arriba
        int direccionY = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Mathf.Sin(angulo) * direccionY;
        Vector2 impulse = new Vector2(x, y);
        rb.AddForce(impulse * force, ForceMode2D.Impulse);
    }

}
