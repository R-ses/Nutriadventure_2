using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    private Gyroscope gyro;
	public GameObject Pause;
    Scoreboard SB;
    public Text score;
   // public GameObject Game;

    // Start is called before the first frame update
    void Start()
    {
        Pause.SetActive(false);
        SB = FindObjectOfType<Scoreboard>();
        gyro = Input.gyro;
    }

    // Update is called once per frame
    void Update()
    {
        
        Gameover();
        score.text = SB.score_value().ToString();

    }

    public void Pause_btn()
    {

        Pause.SetActive(true);
        Debug.Log("Pause");
        gyro.enabled = false;

    }

    public void cont_btn()
    {

        Pause.SetActive(false);
        gyro.enabled = true;

    }

    public void exit_btn()
    {

        Debug.Log("Salir");

    }

    public void Gameover()
    {
        if(SB.carne_f && SB.cereales_f && 
        SB.frutas_f && SB.lacteos_f && 
        SB.verduras_f)
        {

            Debug.Log("Ganaste");

        }

        if(SB.total>=15)
        {
            Debug.Log("Perdiste por excesos");
        }

        if(SB.health <= 30)
        {

            Debug.Log("Muerto");

        }
    }

}



