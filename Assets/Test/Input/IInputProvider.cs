using UnityEngine;

public interface IInputProvider
{
    public Vector2 Move();
    public bool Jump();
}