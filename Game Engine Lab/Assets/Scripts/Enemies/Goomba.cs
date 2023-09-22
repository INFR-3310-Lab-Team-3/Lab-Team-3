using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : BaseEnemy
{
    [SerializeField]
    protected int defense = 1;

    // Start is called before the first frame update
    public override void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }

    // Override for attacking
    public override void Attacking()
    {
        // Does nothing
    }
}
