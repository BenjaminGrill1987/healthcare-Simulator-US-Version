using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathState : BaseState
{
    Enemy basicEnemy;

    public DeathState(Enemy basicEnemy)
    {
        this.basicEnemy = basicEnemy;
    }

    public override void OnEnter()
    {
        basicEnemy.BaseDeath();
    }

    public override void OnExecute()
    {

    }

    public override void OnExit()
    {

    }
}
