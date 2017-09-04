using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTimeSingle : MonoBehaviour {

    public float Lifetime;
    void Start()
    {
        Destroy(gameObject, Lifetime);
    }
}
