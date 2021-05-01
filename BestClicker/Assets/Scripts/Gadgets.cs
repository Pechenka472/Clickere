using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gadgets : MonoSingleton<Gadgets>
{
    public int PointsOnClick { get; protected set; }


    [Range(0,100)] private int SecurityLevel;
    private int PassivPoints;

    private void Awake()
    {
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
