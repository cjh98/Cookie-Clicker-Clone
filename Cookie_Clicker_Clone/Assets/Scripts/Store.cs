using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    public static Store store;

    void Awake()
    {
        store = this;
    }    
}
