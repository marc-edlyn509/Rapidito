using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	//Referencia a nuestro jugador
	public GameObject jugador;

	//Para registrar la diferencia entre la posición de la cámara y la del jugador
	private Vector3 offset;
	void Start () {
		//diferencia entre la posición de la cámara y la del jugador
		offset = transform.position - jugador.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void LateUpdate () {
		//Actualizo la posición de la cámara
		transform.position = jugador.transform.position + offset;
	}
}
