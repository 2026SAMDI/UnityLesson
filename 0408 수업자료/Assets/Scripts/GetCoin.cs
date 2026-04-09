using UnityEngine;

public class GetCoin : MonoBehaviour
{
    [SerializeField] private int scoreValue = 1;
    [SerializeField] private LayerMask coinLayer;
    public int nowScore = 0;

    private void Update()
    {
        // 플레이어 주변에 있는 코인들을 감지
        Collider[] coins = Physics.OverlapSphere(transform.position, 1f, coinLayer);
        // OverlapSphere는 플레이어 위치를 중심으로 반지름이 1f인 구체 영역 내에서 coinLayer에 해당하는 콜라이더들을 감지하는 함수입니다.
        // transform.position는 플레이어의 현재 위치를 나타내며,
        // 1f는 감지 범위, coinLayer는 코인 레이어만 감지하도록 설정

        // for 버전 
        for (int i = 0; i < coins.Length; i++)
        {
            Debug.Log("Coin collected! Score: " + scoreValue);
            nowScore += scoreValue;
            Destroy(coins[i].gameObject);
        }
    }
}
