using System;
using UnityEngine.InputSystem;

[Serializable]
public struct CustomInput<T>
{ 
    public bool isValid;
    public InputAction action;

    public T Value
    {
        get => isValid ? _value : default;
        set => _value = value;
    }

    private T _value;
}
