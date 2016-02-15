using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventario : MonoBehaviour
{
    public List<IItem> Items;
    
    void Start()
    { 
        Items = new List<IItem>();
    }
}
