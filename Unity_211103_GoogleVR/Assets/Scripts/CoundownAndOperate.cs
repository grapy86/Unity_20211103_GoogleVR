using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// �˼ƭp�ɨð�����w�{��
/// �Ҧp�G���}�C���B��ܿ�浥
/// </summary>
public class CoundownAndOperate : MonoBehaviour
{
    #region Field and Property
    [Header("�˼Ʈɶ�"), Range(1, 5)]
    public float timeCountDown = 3;
    [Header("����ƥ�")]
    public UnityEvent onTimeUp;
    [Header("����")]
    public Image imgBar;

    private float timeMax;
    private float timer;

    /// <summary>
    /// �}�l�˼ơAtrue �}�l�Bfalse ����
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
    /// �˼ƭp�ɥ\��
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
