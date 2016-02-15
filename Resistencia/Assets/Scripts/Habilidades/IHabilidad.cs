using UnityEngine;
using System.Collections;

/// <summary>
/// Interface de Habilidad
/// </summary>
/// <remarks>HACK: Unity no maneja correctamente las interfaces, asi que se cambia a una abstract class</remarks>
public abstract class IHabilidad : MonoBehaviour
{
    public abstract void Activar();
}
