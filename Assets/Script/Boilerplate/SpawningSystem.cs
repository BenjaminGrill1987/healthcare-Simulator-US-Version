using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningSystem : Singleton<SpawningSystem>
{
    [SerializeField] Phallus phallus;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Spawn");
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds wait = new WaitForSeconds(phallus.SpawningTime);
        yield return wait;
        for (int i = 0; i < phallus.Sperms.Count; i++)
        {
            for (int j = 0; j < phallus.QuantityPerSperm; j++)
            {
                GameObject unit = Instantiate(phallus.Sperms[i], WayPointHandler.WayPoints.GetStartPoint().position, Quaternion.identity);
                yield return wait;
            }
        }
    }
}