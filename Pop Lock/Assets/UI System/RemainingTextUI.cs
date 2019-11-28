using UnityEngine;
using TMPro;

public class RemainingTextUI : MonoBehaviour
{
    TextMeshPro _text;
    public GameData GameData;

    void Start()
    {
        _text = GetComponent<TextMeshPro>();
        _text.text = GameData.DotsRemaining.ToString();
    }

    void Update()
    {
        _text.text = GameData.DotsRemaining.ToString();        
    }
}
