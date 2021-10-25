using UnityEngine;

public class CarReset : MonoBehaviour
{
    [Header("Script References")]
    [SerializeField] private CarController carController;
    [SerializeField] private Contact contact;

    [Header("Component References")]
    [SerializeField] private Transform carTransform;
    [SerializeField] private Rigidbody carRB;

    [Header("Reset Car")]
    [SerializeField] private bool reset = false;
    [SerializeField] private float resetTime = 5.0f;

    private void Start()
    {
        carController = gameObject.GetComponent<CarController>();
        contact = gameObject.GetComponent<Contact>();

        carTransform = gameObject.GetComponent<Transform>();
        carRB = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        CallResetCar();
    }

    private void FixedUpdate()
    {
        ResetCar();
    }

    private void CallResetCar()
    {
        if (contact.checkCarBodyContact == true && contact.CheckAccelerate() == false && contact.CheckSteer() == false)
        {
            reset = true;

            if (carController.reset == true)
            {
                resetTime = 0.0f;
            }
        }
        else
        {
            reset = false;
        }
    }

    private void ResetCar()
    {
        if (reset == true)
        {
            resetTime -= Time.fixedDeltaTime;

            if (resetTime <= 0.0f)
            {
                carTransform.position = new Vector3(carTransform.position.x, carTransform.position.y + 1.25f, carTransform.position.z);

                if (contact.CheckSteer() == true && contact.CheckAccelerate() == true)
                {
                    carTransform.localEulerAngles = new Vector3(carTransform.localEulerAngles.x, carTransform.localEulerAngles.y, carTransform.localEulerAngles.z);
                }
                else
                {
                    carTransform.localEulerAngles = new Vector3(carTransform.localEulerAngles.x, carTransform.localEulerAngles.y, carTransform.localEulerAngles.z + 180.0f);
                }

                carRB.velocity = new Vector3(0.0f, 0.0f, 0.0f);
                carRB.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);

                resetTime = 5.0f;
            }
        }
    }
}
