using UnityEngine;
using System.Collections;

public class Equipo : MonoBehaviour
{
    public IArma Arma;
    public Armadura Armadura;

    public void Equipar(IArma a) {
        DesequiparArma();
        Arma = a;
    }

    private void DesequiparArma() { 
        //Do something.
    }
}
