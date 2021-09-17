using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class BaseInput : ScriptableObject, IInputProvider
{
    public PlayerLoopTiming loopTiming;
    public CustomInput<Vector2> moveInput;
    public CustomInput<bool> jumpInput;

    public virtual Vector2 Move()
    {
        //virtualなので
        throw new NotImplementedException();
    }

    public virtual bool Jump()
    {
        //virtualなので
        throw new NotImplementedException();
    }
}