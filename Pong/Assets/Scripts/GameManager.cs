using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int p1Score;
    int p2Score;

     [SerializeField] Text txtScoreP1;
     [SerializeField] Text txtScoreP2;

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
        Debug.Log("P1: "+ p1Score+ "| "+ "P2: "+ p2Score);
    }
    void OnGUI(){
        txtScoreP1.text = p1Score.ToString();
        txtScoreP2.text = p2Score.ToString();
    }
}
