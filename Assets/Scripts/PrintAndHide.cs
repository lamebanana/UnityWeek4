using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
	public Renderer rend;
	public int j, i;
	
	
	
    // Start is called before the first frame update
    void Start()
    {
		
		//Random rand = new Random();
		
		j = Random.Range(200, 251);
        i = 3;
		
		
		rend =  GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
		i++;
        Debug.Log(gameObject.name + "'s name:" + i);
		
		if(gameObject.tag == "Red" && i == 100){
			gameObject.SetActive(false);
		}
		
		if(gameObject.tag == "Blue" && i == j){
			rend.enabled = false;
		}
    }
}
