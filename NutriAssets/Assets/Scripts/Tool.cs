using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
	
	int ct_killswitch;
	public GameObject myself;
    Selecter selecter;
	Scoreboard SB;
    // Start is called before the first frame update
    void Start()
    {
        ct_killswitch = 0;
		selecter = FindObjectOfType<Selecter>();
		SB =  FindObjectOfType<Scoreboard>();
	}
	
    void OnTriggerEnter(Collider other)
    {
		selecter.Set_selected();
		SB.update_score(other.transform.gameObject.GetComponent<G_Foes>());
		SB.Update_Sprites();
		selecter.Disapear();
		Debug.Log("Collision");
        //Delete at the end of the collition
		
        Destroy(myself);


    }

    // Update is called once per frame
    void Update()
    {
		ct_killswitch++;
		if(ct_killswitch >= 150)
		{
			Destroy(myself);
		}
    }
	
    


}
