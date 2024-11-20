using UnityEngine;

public class Pelota_controller : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //obtener la referencia del objeto asociado
        rb.AddForce(new Vector2 (1,1), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
