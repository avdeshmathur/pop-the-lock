using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData GameData;
    bool isFirstTap = true;

    void Start()
    {
        GameData.ResetLevel();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !GameData.IsRunning && isFirstTap && !PauseMenu.isGamePause)
        {
            GameData.IsRunning = true;
            isFirstTap = false;
        }
    }

    public void LoadLevel()
    {
        GameData.ResetLevel();
        isFirstTap = true;
    }
}
