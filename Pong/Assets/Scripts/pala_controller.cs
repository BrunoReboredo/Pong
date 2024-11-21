using UnityEngine;
using UnityEngine.UIElements;

public class pala_controller:MonoBehaviour
{

    //Variables
    [SerializeField]const float Max_Y = 4.5f;
    [SerializeField]const float Min_Y = -4.5f;
    [SerializeField] float speed = 4.2f; //al ser la misma velocidad, se usa una variable para evitar problemas
    void Start(){

    }
    void Update(){
        if(gameObject.CompareTag("pala_dere")){
                   if (Input.GetKey("up") && transform.position.y <= Max_Y) {
           // transform.Translate(new Vector3(0, 0.1f, 0)); creas el objeto y le das los valores
           transform.Translate(Vector3.up * speed* Time.deltaTime); //tiene por defecto estos valores de arriba
        }

        if (Input.GetKey("down") && transform.position.y >= Min_Y) {
            //transform.Translate(new Vector3(0, -0.1f, 0)); creas el objeto y le das los valores
            transform.Translate(Vector3.down * speed* Time.deltaTime);
        }
        } else if(gameObject.CompareTag("pala_izqui")){
       if (Input.GetKey("w") && transform.position.y <= Max_Y) {
           // transform.Translate(new Vector3(0, 0.1f, 0)); creas el objeto y le das los valores
           transform.Translate(Vector3.up * speed* Time.deltaTime); //tiene por defecto estos valores de arriba
        }

        if (Input.GetKey("s") && transform.position.y >= Min_Y) {
            //transform.Translate(new Vector3(0, -0.1f, 0)); creas el objeto y le das los valores
            transform.Translate(Vector3.down * speed* Time.deltaTime);
        }
        }

    }
}