using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveWayPointState : BaseState
{
    Enemy basicEnemy;

    public RemoveWayPointState(Enemy basicEnemy)
    {
        this.basicEnemy = basicEnemy;
    }

    public override void OnEnter()
    {
        basicEnemy.RemoveFromList();
    }

    public override void OnExecute()
    {

    }

    public override void OnExit()
    {

    }
}
