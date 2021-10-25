using UnityEngine;

public class CarLap : MonoBehaviour
{
    public int lap;
    public int checkPointIndex;

    private void Start()
    {
        lap = 1;
        checkPointIndex = 0;
    }
}
