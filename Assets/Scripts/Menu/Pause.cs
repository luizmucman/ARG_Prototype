using UnityEngine;
using UnityEngine.InputSystem;

public class Pause : MonoBehaviour
{
    [SerializeField] private InputMenu inputMenu;
    [SerializeField] private InputAction inputPause;

    [SerializeField] private bool pause;

    private void Awake()
    {
        inputMenu = new InputMenu();

        inputPause = inputMenu.PauseMenu.Pause;
        inputPause.started += _ => pause = !pause;
    }

    private void OnEnable()
    {
        inputMenu.Enable();
        inputPause.Enable();
    }

    private void OnDisable()
    {
        inputMenu.Disable();
        inputPause.Disable();
    }

    private void Update()
    {
        PauseGame();
    }

    private void PauseGame()
    {
        if (pause == true)
        {
            Time.timeScale = 0;
            AudioListener.pause = true;
        }
        else
        {
            Time.timeScale = 1;
            AudioListener.pause = false;
        }
    }
}
