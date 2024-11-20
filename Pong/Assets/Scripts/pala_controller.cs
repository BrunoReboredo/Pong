using UnityEngine;

public class pala_controller:MonoBehaviour
{
    void Start(){

    }
    void Update(){
       if (Input.GetKey("up")) {
           // transform.Translate(new Vector3(0, 0.1f, 0)); creas el objeto y le das los valores
           transform.Translate(Vector3.up * 0.1f); //tiene por defecto estos valores de arriba
        }

        if (Input.GetKey("down")) {
            //transform.Translate(new Vector3(0, -0.1f, 0)); creas el objeto y le das los valores
            transform.Translate(Vector3.down * 0.1f);
        }
    }
}
