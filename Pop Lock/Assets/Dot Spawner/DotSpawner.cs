using UnityEngine;

public class DotSpawner : MonoBehaviour
{
    public AnchorMovement Motor;
    public GameObject DotPrefab;
    public GameObject StarredDotPrefab;
    public GameData GameData;
    Transform anchor;
    
    void Start()
    {
        anchor = GameObject.FindGameObjectWithTag("Anchor").transform;
        Spawn();
    }

    public void Spawn()
    {
        RemoveDuplicates();

        var angle = Random.Range(GameData.MinimumSpawnAngle, GameData.MaximumSpawnAngle);
        var go = Instantiate(selectRandomDot(), Motor.transform.position, Quaternion.identity, transform);
        go.transform.RotateAround(anchor.transform.position, Vector3.forward, -angle * (int)Motor.direction);
    }

    public GameObject selectRandomDot()
     {
        if (Random.value < 0.2f)
        {
            return StarredDotPrefab;
        }else
        {
            return DotPrefab;
        }
     }

    public void RemoveDuplicates() {

        var dots = GameObject.FindGameObjectsWithTag("Dot");
        foreach(var dot in dots)
        {
            Destroy(dot);
        }
    }
}
