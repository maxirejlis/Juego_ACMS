using UnityEngine;
using System.Collections;

public class ArmaRango : MonoBehaviour, IArma
{
    public float RangoMaximo;
    public float Fuerza ;
    public float CoolDownDisparo ;
    /// <summary>
    /// Porcentaje de precision de 0 a 1
    /// </summary>
    public float PorcentajePrecision ;

    public int CantidadBalas ;
    public int CantidadMaximaBalas ;

    public float VelocidadProyectil ;

    private float CoolDownActual { get; set; }

    public ArmaRango() 
    {
        CoolDownActual = CoolDownDisparo;
    }

    public void Atacar(Vector3 Direccion)
    {
        if (CoolDownActual < CoolDownDisparo)
            return;
        if (CantidadBalas <= 0)
            return;



        Debug.Log("Ataco con el arma.");
        CantidadBalas -= 1;
        CoolDownActual = 0;       
    }

    public void Update()
    {
        CoolDownActual += Time.deltaTime;
    }
}
