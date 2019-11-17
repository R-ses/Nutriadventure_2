using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    
    public int Score=0;
    public float Carne=0;
    public float Lacteos=0;
    public float Verduras=0;
    public float Cereales=0;
    public float Frutas=0;
	
	public int M_Carne;
	public int M_Lacteos;
	public int M_Verduras;
	public int M_Cereales;
	public int M_Frutas;
	
	public Text L_Score;
	public Image _Carne;
	public Image _Lacteos;
	public Image _Verduras;
	public Image _Cereales;
	public Image _Frutas;
	
    void Start()
    {
		clear_sprites();
		Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
		
		
    }
	
	public void Update_Sprites()
	{
		
		_Carne.fillAmount += Carne / M_Carne;
		_Cereales.fillAmount += Cereales / M_Cereales;
		_Verduras.fillAmount += Verduras / M_Verduras;
		_Frutas.fillAmount += Frutas / M_Frutas;
		_Lacteos.fillAmount += Lacteos / M_Lacteos;
		
		
	}
	
	void clear_sprites()
	{
		
		_Carne.fillAmount -= 1;
		_Cereales.fillAmount -= 1;
		_Verduras.fillAmount -= 1;
		_Frutas.fillAmount -= 1;
		_Lacteos.fillAmount -= 1;

	}
	
	public void update_score(G_Foes c)
	{
		this.Carne += c.Animal*0.1f;
		this.Lacteos += c.lacteos*0.1f;
		this.Verduras += c.Verduras*0.1f;
		this.Cereales += c.Cereales*0.1f;
		this.Frutas += c.Frutas*0.1f;
		this.Score += c.Points;
		
		
	}
}
