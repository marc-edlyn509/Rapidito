using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour {
	public Text p11, p22;
	//public GameObject JJ, ENM;
	//private int p1 = JJ.GetComponentInChildren(typeof(int)) as int, p2=0;
	public Text df;

	// Use this for initialization
	void Start () {
		df.text = "";
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Definir ();
	}

	 /*void Definir(){
		//p1 = int.Parse (p11.text.ToString());
		//p2 = int.Parse (p22.text.ToString());
		
		if (p1 + p2 >= 110) {
			if (p1 > p2) {
				df.text = "¡VICTORIA PARA Player 1!!!";
			} else if (p1 < p2) {
				df.text = "¡VICTORIA PARA Player 2!!!";
			} else {
				df.text = "¡EMPATEEEEE!!!";
			}
		}

	}*/
}
