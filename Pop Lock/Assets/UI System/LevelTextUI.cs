using UnityEngine;
using TMPro;

public class LevelTextUI : MonoBehaviour
{
    TextMeshProUGUI _text;
    public GameData GameData;

    void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _text.text = "Level: " + GameData.CurrentLevel.ToString();
    }

    void Update()
    {
        _text.text = "Level: " + GameData.CurrentLevel.ToString();
    }
}
