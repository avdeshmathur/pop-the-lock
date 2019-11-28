using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotDetector : MonoBehaviour
{

    GameObject currentDot;
    GameObject lastEnteredDot;
    private float loseThreshold = 0.2f;
    public GameEvent OnDotMissed;
    public GameEvent OnDotScore;
    public GameEvent OnWinEvent;
    public GameData GameData;
    
    void OnTriggerEnter2D(Collider2D col){
        currentDot = col.gameObject;
    }

    void OnTriggerExit2D(Collider2D col){
        lastEnteredDot = currentDot;
        currentDot = null;
    }

    void Update()
    {
        if (GameData.IsRunning)
        {
            if (lastEnteredDot && getDistanceFromLastDot() > loseThreshold)
            {
                OnDotMissed.Raise();
            }
            if (_didTap)
            {

                if (currentDot != null)
                {
                    if (currentDot.GetComponent<Stars>())
                    {
                        GameData.Stars++;
                    }
                    Destroy(currentDot);
                    GameData.DotsRemaining--;

                    if (GameData.DotsRemaining <= 0)
                    {
                        GameData.DotsRemaining = 0;
                        GameData.CurrentLevel++;
                        OnWinEvent.Raise();
                    }
                    else
                    {
                        OnDotScore.Raise();
                    }
                }
                else
                {
                    OnDotMissed.Raise();
                }
            }
        }
    }

    float getDistanceFromLastDot()
    {
        return (transform.position - lastEnteredDot.transform.position).magnitude;
    }

    bool _didTap
    {
        get
        {
            return Input.GetMouseButtonDown(0);
        }
    }
}
