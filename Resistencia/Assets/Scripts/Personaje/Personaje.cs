using System.Linq;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Personaje : MonoBehaviour {

    public int HP;
    public Equipo Equipo;
    public Inventario Inventario;
    public IList<IHabilidad> Habilidades;
    

	// Use this for initialization
	void Start () 
    {
        Habilidades = new List<IHabilidad>();
        Habilidades.Add(new HabilidadFireball(this.transform));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// Funcion a llamar cuando el personaje fue golpeado
    /// </summary>
    /// <param name="daño">Daño del impacto. [Update Vida]</param>
    /// <param name="posicionDesde">Posicion desde la que se lo ataco. [Para realizar la fisica]</param>
    /// <param name="fuerzaDeImpacto">Fuerza del impacto recibido. [Para realizar la fisica]</param>
    public void FueGolpeado(int daño, Vector3 posicionDesde, int fuerzaDeImpacto) { 
    
    }
}
