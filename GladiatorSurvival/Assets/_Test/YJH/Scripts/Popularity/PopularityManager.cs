using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class PopularityManager : MonoBehaviour
{
    #region 싱글톤 패턴
    public static PopularityManager Instance
    {
        get
        {
            // 만약 싱글톤 변수에 아직 오브젝트가 할당되지 않았다면
            if (m_Instance == null)
            {
                // 씬에서 PopularityManager 오브젝트를 찾아 할당
                GameObject popularityManager = new GameObject("PopularityManager");
                m_Instance = popularityManager.AddComponent<PopularityManager>();
            }
            // 싱글톤 오브젝트를 반환
            return m_Instance;
        }
    }
    private static PopularityManager m_Instance; // 싱글톤이 할당될 static 변수    
    #endregion

    [Header("Popularity")]
    public int maxPopularity;   // 최대 인기도
    public int curPopularity;   // 현재 인기도

    [Header("Buff")]
    public float popularBuff;   // 버프
    public float popularDebuff; // 디버프

    // 인기도 세팅
    public void SetPopularity(int value)
    {
        curPopularity = value;
    }


    // 인기도 계승



}
