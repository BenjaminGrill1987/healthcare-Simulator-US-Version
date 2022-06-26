using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Phallus : MonoBehaviour
{
    [SerializeField] PhallusStats stats;
    private float spawningTime;
    private List<GameObject> sperms;
    private int quantityPerSperm;
    private Sprite sprite;

    public int QuantityPerSperm { get => quantityPerSperm; }
    public List<GameObject> Sperms { get => sperms; }
    public float SpawningTime { get => spawningTime; }

    protected virtual void Start()
    {
        SetStats();
    }

    private void SetStats()
    {
        stats.GetStats(out sprite, out sperms, out quantityPerSperm, out spawningTime);
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
