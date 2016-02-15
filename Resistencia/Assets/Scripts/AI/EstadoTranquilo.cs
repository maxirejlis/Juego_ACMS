using UnityEngine;
using System.Collections;

public class EstadoTranquilo : IEstado 
{
    public EstadoTranquilo()
    {
        throw new System.ApplicationException("No puede iniciar un estado sin asignar el poseedor del estado");
    }

    public EstadoTranquilo(Monstruo m) {
        Monstruo = m;
    }

    private float TimeForMovement = 5;
    private float ActualTime = 0f;
    
    public override void Do()
    {
        if (ActualTime > TimeForMovement) {
            ActualTime = 0f;
            Debug.Log("Estoy tranquilo!");
            this.Monstruo.Estado = new EstadoEnojado(Monstruo);
        }
        ActualTime += Time.deltaTime;
    }
}
