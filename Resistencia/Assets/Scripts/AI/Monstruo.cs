using UnityEngine;
using System.Collections;

public class Monstruo : MonoBehaviour {

    public IEstado Estado;

	// Use this for initialization
	void Start () {
        Estado = new EstadoEnojado(this);
	}
	
	// Update is called once per frame
	void Update () {
        Estado.Do();
	}
}
