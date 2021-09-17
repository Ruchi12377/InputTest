using UnityEngine;

[CreateAssetMenu(menuName = "SampleInput", fileName = "SampleInput", order = 0)]
public class InputSystemWrapper : BaseInput
{
    public override Vector2 Move()
    {
        return moveInput.Value;
    }

    public override bool Jump()
    {
        return jumpInput.Value;
    }
}