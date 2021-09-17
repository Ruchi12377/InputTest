using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        Debug.Log(InputManager.Instance.input.moveInput.Value);
        Debug.Log(InputManager.Instance.input.jumpInput.Value);
    }
}
