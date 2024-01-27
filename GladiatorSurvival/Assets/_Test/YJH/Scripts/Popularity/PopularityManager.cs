using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class PopularityManager : MonoBehaviour
{
    #region �̱��� ����
    public static PopularityManager Instance
    {
        get
        {
            // ���� �̱��� ������ ���� ������Ʈ�� �Ҵ���� �ʾҴٸ�
            if (m_Instance == null)
            {
                // ������ PopularityManager ������Ʈ�� ã�� �Ҵ�
                GameObject popularityManager = new GameObject("PopularityManager");
                m_Instance = popularityManager.AddComponent<PopularityManager>();
            }
            // �̱��� ������Ʈ�� ��ȯ
            return m_Instance;
        }
    }
    private static PopularityManager m_Instance; // �̱����� �Ҵ�� static ����    
    #endregion

    [Header("Popularity")]
    public int maxPopularity;   // �ִ� �α⵵
    public int curPopularity;   // ���� �α⵵

    [Header("Buff")]
    public float popularBuff;   // ����
    public float popularDebuff; // �����

    // �α⵵ ����
    public void SetPopularity(int value)
    {
        curPopularity = value;
    }


    // �α⵵ ���



}
