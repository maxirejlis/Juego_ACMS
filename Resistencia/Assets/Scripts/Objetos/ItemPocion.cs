using UnityEngine;
using System.Collections;

public class ItemPocion : IItem
{
    public override void Usar()
    {
        Debug.Log("Uso una pocion");
    }

    public override IItem CrearItem()
    {
        return new ItemPocion();
    }
}
