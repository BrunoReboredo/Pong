using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Pelota_controller : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]float force;
    [SerializeField] float delay;
    const float angle_min= -20;
    const float angle_max = 40;
    const float max_Y = 2.5f;
    const float min_Y = 2.5f;
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //obtener la referencia del objeto asociado
        //rb.AddForce(new Vector2 (1,1) * force, ForceMode2D.Impulse); // con esta linea la pelota siempre sale en la misma dirección.
        //hacer que salga aleatorio
        int direccionX = Random.Range(0, 2) == 0 ? -1 : 1;
        StartCoroutine(LanzamientoDePelota(direccionX));
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
        Debug.Log ("Gol "+ other.tag);

        if (other.tag== "Porteria_dere"){
            StartCoroutine(LanzamientoDePelota(1));
        }else if (other.tag == "Porteria_izqui"){
            StartCoroutine(LanzamientoDePelota(-1));
        }
    }

    //Hace un random para elegir el angulo de lanzamiento de la pelota. Eje X e Y
    IEnumerator LanzamientoDePelota(int direccionX){

        yield return new WaitForSeconds(delay);

        // Calculo de la posición vertical de lanzamiento
        float posY = Random.Range(min_Y, max_Y);
        transform.position = new Vector3 (0, posY, 0);

        //Calculo del vector de lanzamiento
        float angulo  = Random.Range(angle_min, angle_max)* Mathf.Deg2Rad;
        float x = Mathf.Cos(angulo) * direccionX;
        // hace q si sale 0 sea -1 (para abajo) y si sale uno sale para arriba
        int direccionY = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Mathf.Sin(angulo) * direccionY;
        Vector2 impulse = new Vector2(x, y);

        //resetear la velocidad de la pelota cad vez q sale
       // rb.linearVelocityY = Vector2.zero;
        rb.AddForce(impulse * force, ForceMode2D.Impulse);
    }

}