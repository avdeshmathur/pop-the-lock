using UnityEngine;

[CreateAssetMenu]
public class GameData : ScriptableObject
{
    public int CurrentLevel;
    public int DotsRemaining;
    public int Stars;
    public int MaximumSpawnAngle = 30;
    public int MinimumSpawnAngle = 90;
    public int MaxMotorSpeed = 100;
    public int MinMotorSpeed = 60;
    public int CurrentMotorSpeed = 55;
    public bool IsRunning = false;

    public void ResetLevel()
    {
        DotsRemaining = CurrentLevel;
        IsRunning = false;
    }

    public void ResetData()
    {
        CurrentLevel = 1;
        DotsRemaining = CurrentLevel;
        CurrentMotorSpeed = MinMotorSpeed;
    }
    public void IncreaseMotorSpeed(int value)
    {
        if (value > 0)
        {
            CurrentMotorSpeed = Mathf.Min(CurrentMotorSpeed + value, MaxMotorSpeed);
        }
    }

    public void ReduceMotorSpeed(int value)
    {
        if (value > 0)
        {
            CurrentMotorSpeed = Mathf.Max(CurrentMotorSpeed - value, MinMotorSpeed);
        }
    }
    public void StopGame()
    {
        IsRunning = false;
    }
}
