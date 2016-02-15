using UnityEngine;
using System.Collections;

public class HabilidadFireball : IHabilidad 
{
    public Transform TransformPersonaje;
    public HabilidadFireball(Transform t) {
        TransformPersonaje = t;
    }
    public override void Activar()
    {
        Debug.Log("Activo la habilidad Fireball.");
        var fireball = Resources.Load<GameObject>("Fireball");
        Debug.Log(TransformPersonaje.position);
        fireball.transform.position = TransformPersonaje.position;
        Instantiate<GameObject>(fireball);
    }

    void OnTriggerEnter() { 
        //En realidad igual que con los disparos, si es una habilidad que sea un proyectil hacerlo con raycast.
    }
}
