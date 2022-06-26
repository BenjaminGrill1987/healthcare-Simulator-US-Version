using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu(menuName = "Enemy/PhallusStats")]
public class PhallusStats : ScriptableObject
{
    [ShowAssetPreview]
    [SerializeField] Sprite sprite;
    [SerializeField] List<GameObject> sperm;
    [SerializeField] int quantityPerSperm;
    [SerializeField] float spawningTime;

    public void GetStats(out Sprite sprite, out List<GameObject> sperm, out int quantityPerSperm, out float spawningTime)
    {
        sprite = this.sprite;
        sperm = this.sperm;
        quantityPerSperm = this.quantityPerSperm;
        spawningTime = this.spawningTime;
    }
}
