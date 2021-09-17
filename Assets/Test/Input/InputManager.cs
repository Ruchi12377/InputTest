using Cysharp.Threading.Tasks;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //InputManagerのインスタンス
    public static InputManager Instance => _instance ? _instance : _instance = FindObjectOfType<InputManager>();
    private static InputManager _instance;
    
    //インスペクター等でよしなにしたInputデバイス
    public BaseInput input;

    #region InputActionのための処理
    
    private void OnEnable()
    {
        //nullなので
        if(input == null){
            return;
        }
        //ここをベタ書きするのをどうにかしたい。。。
        //Listはあまり良くない(結局indexで実装しなきゃいけなくなったりするので...)
        input.moveInput.action?.Enable();
        input.jumpInput.action?.Enable();
    }

    private void OnDisable()
    {
        //nullなので
        if(input == null){
            return;
        }
        input.moveInput.action?.Disable();
        input.jumpInput.action?.Disable();
    }

    private void OnDestroy()
    {
        //nullなので
        if(input == null){
            return;
        }
        input.moveInput.action?.Disable();
        input.jumpInput.action?.Disable();
    }
    
    private void Awake()
    {
        //nullなので
        if(input == null){
            return;
        }
        
        input.moveInput.action.started += x =>
        {
            input.moveInput.Value = x.ReadValue<Vector2>();
        };
        
        input.moveInput.action.canceled += x =>
        {
            input.moveInput.Value = x.ReadValue<Vector2>();
        };

        input.jumpInput.action.started += x =>
        {
            Jump();
        };
    }

    private async void Jump()
    {
        input.jumpInput.Value = true;
        await UniTask.DelayFrame(1, input.loopTiming);
        input.jumpInput.Value = false;
    }
    #endregion
}
