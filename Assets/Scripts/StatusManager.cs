using UnityEngine;

// �X�e�[�^�X���Ǘ�����
public class StatusManager : MonoBehaviour
{
    // �X�e�[�^�X
    public enum Status
    {
        HP,
        Attack,
    }

    // �{�^������X�e�[�^�X�̏㏸
    public void OnAddStatus(int status)
    {
        // 
        switch ((Status)status)
        {
            case Status.HP:
            break;

            case Status.Attack:
            break;

            default:
            Debug.LogError("�w��̒l������܂���ł����B");
            break;
        }
    }
}
