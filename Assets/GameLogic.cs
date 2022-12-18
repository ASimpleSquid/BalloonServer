using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    float durationUntilNextBalloon;
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

            float screenPositionXPercent = Random.Range(0.0f, 1.0f);
            float screenPositionYPercent = Random.Range(0.0f, 1.0f);
        }
    }

}
