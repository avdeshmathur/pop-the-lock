using UnityEngine;
using TMPro;

public class StarsTextUI : MonoBehaviour
{
    TextMeshProUGUI _text;
    public GameData GameData;

    void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _text.text = "Stars: " + GameData.Stars.ToString();
    }

    void Update()
    {
        _text.text = "Stars: " + GameData.Stars.ToString();
    }
}
