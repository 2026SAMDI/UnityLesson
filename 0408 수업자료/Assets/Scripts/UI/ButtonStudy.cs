using UnityEngine;
using UnityEngine.UI;

public class ButtonStudy : MonoBehaviour
{
    private int count = 0;
    [SerializeField] private Text countText;

    public void OnButtonClick()
    {
        count++;
        countText.text = count.ToString();
    }
}
