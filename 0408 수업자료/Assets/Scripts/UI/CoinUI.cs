using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private Text coinText;
    [SerializeField] private GetCoin getCoin;

    private void Update()
    {
        coinText.text = "Coins: " + getCoin.nowScore.ToString();
    }
}
