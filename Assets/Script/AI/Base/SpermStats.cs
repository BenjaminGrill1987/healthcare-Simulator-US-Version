using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu (menuName = "Enemy/SpermStats")]
public class SpermStats : ScriptableObject
{
    [SerializeField] private int life, money;
    [ShowAssetPreview]
    [SerializeField] private Sprite sprite;
    [SerializeField] private float movementSpeed, maxDistance;
    [SerializeField] bool flying, invisible, canAttack;
    [ShowIf("canAttack")]
    [SerializeField] private int damage;

    public void GetStats(out int life, out int money, out Sprite sprite, out float movementSpeed,out float maxDistance , out bool flying, out bool invisible, out bool canAttack, out int damage)
    {
        life = this.life;
        money = this.money;
        sprite = this.sprite;
        movementSpeed = this.movementSpeed;
        maxDistance = this.maxDistance;
        flying = this.flying;
        invisible = this.invisible;
        canAttack = this.canAttack;
        damage = this.damage;
    }
}
