using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// VR ���ʪ���
/// 1. VR �`���I�ݨ즹���� Enter
/// 2. VR �`���I�ݨ�����}������ Exit
/// 3. VR �`���I�ݨ즹������I�郎�ʫ��s Click
/// </summary>
public class VRInteractionObject : MonoBehaviour
{
    /// <summary>
    /// �Q�Τ��� UnityEvent �t�Υi�u�ʽվ㤬�ʪ���²��ƥ�
    /// �������Ҧ������W���g script
    /// </summary>
    [Header("�ƥ�G�ݨ�B���}�P�I��"), Space(10)]
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
