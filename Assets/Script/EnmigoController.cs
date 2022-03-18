using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnmigoController : MonoBehaviour {
	private Rigidbody rb;

	public float velocidad;
	private int contador=0;
	public Text textoContador, textoGanar;

	void Start () {
		rb = GetComponent<Rigidbody>();
		setTextoContador ();
		textoGanar.text = "";
	}



	void FixedUpdate () {

		float movimientoH = Input.GetAxis("Horizontal_1");
		float movimientoV = Input.GetAxis("Vertical_1");
		//Un vector 3 es un trío de posiciones en el espacio XYZ, en este caso el que corresponde al movimiento
		Vector3 movimiento = new Vector3(movimientoH, 0.0f,
			movimientoV);

		rb.AddForce(movimiento * velocidad);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Gold")) {		
			contador += 5;
			other.gameObject.SetActive (false);
			setTextoContador ();
		}
		else if (other.gameObject.CompareTag ("Silver")) {
			contador += 3;
			other.gameObject.SetActive (false);
			setTextoContador ();
		} else if (other.gameObject.CompareTag ("Coleccio")){
			contador++;
			other.gameObject.SetActive (false);
			setTextoContador ();
		}



	}
	void setTextoContador(){
		textoContador.text = "Player 2: " + contador.ToString();
		if (contador >= 56) {
			textoGanar.text = "¡Victoria para el Jugador 2";
		}
	}

}