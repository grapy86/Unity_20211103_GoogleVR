using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// VR 互動物件
/// 1. VR 注視點看到此物件 Enter
/// 2. VR 注視點看到後離開此物件 Exit
/// 3. VR 注視點看到此物件並點選互動按鈕 Click
/// </summary>
public class VRInteractionObject : MonoBehaviour
{
    /// <summary>
    /// 利用內建 UnityEvent 系統可彈性調整互動物件簡單事件
    /// 不須為所有物件單獨撰寫 script
    /// </summary>
    [Header("事件：看到、離開與點擊"), Space(10)]
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent onClick;

    public void OnPointerEnter()
    {
        onEnter.Invoke();
    }

    public void OnPointerExit()
    {
        onExit.Invoke();
    }

    public void OnPointerClick()
    {
        onClick.Invoke();
    }
}
