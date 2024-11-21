using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int p1Score;
    int p2Score;

    Boolean running = false;

     [SerializeField] Text txtScoreP1;
     [SerializeField] Text txtScoreP2;
    [SerializeField] GameObject pelota;

    public void AddPointp1(){
        p1Score++;
    }

    public void AddPointp2(){
        p2Score++;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log("P1: "+ p1Score+ "| "+ "P2: "+ p2Score);

      //este if hace la pelota visible al principio si el jugador pulsa espacio
      if (!running && Input.GetKeyDown(KeyCode.Space)){
        pelota.SetActive(true);
        running= true;
      } 

      //este if cierra el juego si el jugador pulsa escape
      if(Input.GetKeyDown(KeyCode.Escape)){
        Application.Quit();
      }

    }
    void OnGUI(){
        txtScoreP1.text = p1Score.ToString();
        txtScoreP2.text = p2Score.ToString();
    }
}
