using UnityEngine;
using System.Collections;

public class EstadoEnojado :  IEstado 
{
    public EstadoEnojado() {
        throw new System.ApplicationException("No puede iniciar un estado sin asignar el poseedor del estado");
    }

    public EstadoEnojado(Monstruo m)
    {
        Monstruo = m;
    }

    private float TimeForMovement = 5;
    private float ActualTime = 0f;
    
    public override void Do()
    {
        if (ActualTime > TimeForMovement) {
            ActualTime = 0f;
            Debug.Log("Estoy Muy enojado y te voy a pegar!");
            this.Monstruo.Estado = new EstadoTranquilo(Monstruo);
        }
        ActualTime += Time.deltaTime;
    }
}
