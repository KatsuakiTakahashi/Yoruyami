using UnityEngine;

// ステータスを管理する
public class StatusManager : MonoBehaviour
{
    // ステータス
    public enum Status
    {
        HP,
        Attack,
    }

    // ボタンからステータスの上昇
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
            Debug.LogError("指定の値がありませんでした。");
            break;
        }
    }
}
