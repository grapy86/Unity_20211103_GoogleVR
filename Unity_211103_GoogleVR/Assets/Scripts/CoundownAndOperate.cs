using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// 倒數計時並執行指定程序
/// 例如：離開遊戲、顯示選單等
/// </summary>
public class CoundownAndOperate : MonoBehaviour
{
    #region Field and Property
    [Header("倒數時間"), Range(1, 5)]
    public float timeCountDown = 3;
    [Header("執行事件")]
    public UnityEvent onTimeUp;
    [Header("介面")]
    public Image imgBar;

    private float timeMax;
    private float timer;

    /// <summary>
    /// 開始倒數，true 開始、false 停止
    /// </summary>
    public bool startCountDown { get; set; }
    #endregion

    private void Awake()
    {
        timeMax = timeCountDown;
    }

    private void Update()
    {
        CountDown();
    }    

    /// <summary>
    /// 倒數計時功能
    /// </summary>
    private void CountDown()
    {
        if (startCountDown)
        {
            if (timer < timeCountDown)
            {
                timer += Time.deltaTime;
            }
            else
            {
                onTimeUp.Invoke();
            }
            imgBar.fillAmount = timer / timeMax;
        }
        else
        {
            timer = 0;
            imgBar.fillAmount = 0;
        }        
    }
}
