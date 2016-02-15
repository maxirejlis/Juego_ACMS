using UnityEngine;
using System.Collections;

public class ControladorHabilidades : MonoBehaviour
{
    private Personaje p;
	// Use this for initialization
	void Start () {
        p = this.GetComponent<Personaje>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            p.Habilidades[0].Activar();
        }
	}
}
