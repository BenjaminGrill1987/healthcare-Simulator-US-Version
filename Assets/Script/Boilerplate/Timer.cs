using UnityEngine;

public class Timer
{
    private float currentTime;
    private float maxTime;

    public float CurrentTime { get => currentTime; }

    public void SetTimer(float time)
    {
        currentTime = time;
        maxTime = time;
    }

    public void Tick()
    {
        currentTime -= Time.deltaTime;
    }

    public void Reset()
    {
        currentTime = maxTime;
    }
}
