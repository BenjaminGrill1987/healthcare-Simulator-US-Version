using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Enemy : MonoBehaviour, iDamageAble
{
    [ShowNonSerializedField] protected int life, damage, money;
    [ShowNonSerializedField] private float movementSpeed;

    private Sprite sprite;
    private bool flying, invisible, canAttack;

    private List<GameObject> wayPoints;

    private float maxDistance;

    [SerializeField] protected SpermStats stats;

    [SerializeField] protected Slider healthBar;

    public List<GameObject> WayPoints { get => wayPoints; }
    public float MaxDistance { get => maxDistance; }
    public float MovementSpeed { get => movementSpeed; }

    protected virtual void Start()
    {
        SetStats();
        GetWayPoints();
    }

    public void DamageTaken(int damage)
    {
        life -= damage;
        healthBar.value = life;
        if (life <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        AddMoney();
        Destroy(gameObject);
    }

    public void BaseDeath()
    {
        Destroy(gameObject);
    }

    private void SetStats()
    {
        stats.GetStats(out life, out money, out sprite, out movementSpeed,out maxDistance, out flying, out invisible, out canAttack, out damage);
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
        //healthBar.maxValue = life;
        //healthBar.value = life;
    }

    private void GetWayPoints()
    {
        wayPoints = new List<GameObject>(WayPointHandler.WayPoints.GetWayPoints());
    }

    public void RemoveFromList()
    {
        wayPoints.Remove(wayPoints[0]);
    }

    private void AddMoney()
    {

    }

   // private void LateUpdate()
   // {
   //     healthBar.transform.LookAt(healthBar.transform.position + Camera.main.transform.forward);
   // }
}
