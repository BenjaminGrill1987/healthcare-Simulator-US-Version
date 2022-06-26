using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointHandler : Singleton<WayPointHandler>
{
    [SerializeField] WayPointPlacingSystem wayPoints;

    public static WayPointPlacingSystem WayPoints { get => Instance.wayPoints;}

}