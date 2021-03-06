using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyStateMachine : BaseStateMachine
{
    Enemy basicEnemy;
    BaseState idleState;
    BaseState moveState;
    BaseState deathState;
    BaseState removeWaypointState;

    public BaseEnemyStateMachine(Enemy basicEnemy)
    {
        this.basicEnemy = basicEnemy;
        idleState = new IDLEState();
        moveState = new MoveState(basicEnemy);
        deathState = new DeathState(basicEnemy);
        removeWaypointState = new RemoveWayPointState(basicEnemy);

        DefineTransition();
        ChangeState(moveState);
    }

    protected override void DefineTransition()
    {
        moveState.AddTransition(CheckIfEnd, deathState);
        moveState.AddTransition(CheckDistance, removeWaypointState);

        removeWaypointState.AddTransition(CheckNewDistance, moveState);
    }

    bool CheckIfEnd()
    {
        var distance = Vector3.Distance(basicEnemy.transform.position, basicEnemy.WayPoints[0].transform.position);
        return distance < basicEnemy.MaxDistance && basicEnemy.WayPoints[0].name == "End";
    }

    bool CheckDistance()
    {
        var distance = Vector3.Distance(basicEnemy.transform.position, basicEnemy.WayPoints[0].transform.position);
        return distance < basicEnemy.MaxDistance;
    }

    bool CheckNewDistance()
    {
        var distance = Vector3.Distance(basicEnemy.transform.position, basicEnemy.WayPoints[0].transform.position);
        return distance > basicEnemy.MaxDistance;
    }
}
