using UnityEngine;

public class CheckPointHandler : MonoBehaviour
{
    private GameObject checkPoint;

    [Header("Attributes")]
    [SerializeField] static private int checkPointAmount;
    public int index;

    private void Start()
    {
        checkPoint = gameObject;
        checkPointAmount++;

        index = checkPoint.transform.GetSiblingIndex() + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CarLap>() == true)
        {
            CarLap car = other.GetComponent<CarLap>();

            if (car.checkPointIndex == index - 1)
            {
                car.checkPointIndex = index;
            }

            if (car.checkPointIndex == checkPointAmount && index == 1)
            {
                car.checkPointIndex = 1;
                car.lap++;
            }
        }
    }
}
