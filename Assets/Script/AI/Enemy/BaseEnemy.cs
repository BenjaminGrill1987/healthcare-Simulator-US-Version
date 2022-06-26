using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : Enemy
{
    BaseStateMachine stateMachine;

    protected override void Start()
    {
        base.Start();
        stateMachine = new BaseEnemyStateMachine(this);
    }

    private void Update()
    {
        stateMachine.ExecuteState();
    }
}
