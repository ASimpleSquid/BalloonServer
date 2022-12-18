using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    float durationUntilNextBalloon;
    public List<Balloon> balloons;
    public int nextID = 0;
    void Start()
    {
        NetworkedServerProcessing.SetGameLogic(this);
    }

    void Update()
    {
        durationUntilNextBalloon -= Time.deltaTime;

        if (durationUntilNextBalloon < 0)
        {
            durationUntilNextBalloon = 1f;
        }
    }

    public void SpawnNewBalloon()
    {
        float screenPositionXPercent = Random.Range(0.0f, 1.0f);
        float screenPositionYPercent = Random.Range(0.0f, 1.0f);

        Balloon balloon = new Balloon(screenPositionXPercent,screenPositionYPercent,nextID++);
    }

}

public struct Balloon
{
    public float x;
    public float y;
    public int id;

    public Balloon(float x, float y, int id)
    {
        this.x = x;
        this.y = y;
        this.id = id;

    }
    public override string ToString() => $"{x},{y},{id}";
}
