using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : BaseState
{
    Enemy basicEnemy;

    public MoveState(Enemy basicEnemy)
    {
        this.basicEnemy = basicEnemy;
    }

    public override void OnEnter()
    {

    }

    public override void OnExecute()
    {
        Vector3 direction = (basicEnemy.WayPoints[0].transform.position - basicEnemy.transform.position).normalized;

        Quaternion lookRotation = Quaternion.LookRotation(direction);
        Vector3 rotation = lookRotation.eulerAngles;


        basicEnemy.transform.position += direction * basicEnemy.MovementSpeed * Time.deltaTime;
    }

    public override void OnExit()
    {

    }
}
