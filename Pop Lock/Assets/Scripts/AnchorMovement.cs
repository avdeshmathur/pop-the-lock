using UnityEngine;

public class AnchorMovement : MonoBehaviour
{
    Transform anchor;
    public Direction direction = Direction.Clockwise;
    Vector3 initialPos;
    public GameData GameData;
    public GameEvent OnPaddleReset;


    void Start()
    {
        anchor = GameObject.FindGameObjectWithTag("Anchor").transform;
        initialPos = GetComponent<Transform>().localPosition;
    }

    void Update()
    {
        if (GameData.IsRunning){

            transform.RotateAround(anchor.position, Vector3.forward, GameData.CurrentMotorSpeed * Time.deltaTime * -(int) direction);
        }

        if (didTap && GameData.IsRunning)
        {     
            ChangeDirection();
        }
    }

    bool didTap{

        get{

            return Input.GetMouseButtonDown(0);
        }
    }

    void ChangeDirection(){
        switch(direction){
            case Direction.Clockwise:
            direction = Direction.AntiClockwise;
            break;
            case Direction.AntiClockwise:
            direction = Direction.Clockwise;
            break;
        }
    }



    public enum Direction{
        Clockwise = 1,
        AntiClockwise = -1
    }

    public void ResetPosition()
    {
        transform.localPosition = new Vector3(0, initialPos.y, 0);
        transform.rotation = Quaternion.identity;
        OnPaddleReset.Raise();
    }

    public void Stop()
    {
        GameData.IsRunning = false;
    }
}
