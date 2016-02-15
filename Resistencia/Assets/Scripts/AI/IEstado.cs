using UnityEngine;
using System.Collections;

/// <summary>
/// Interface de Estado
/// </summary>
public abstract class IEstado
{
    public Monstruo Monstruo;

    public abstract void Do();
}
