using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{
    protected override void OnHit()
    {
        //Stop for 1 second when hit then keep moving
        MoveSpeed = 0;
        Invoke("Pause", 1.0f);
    }

    public void Pause()
    {

        MoveSpeed = 0.05f;
    }
}