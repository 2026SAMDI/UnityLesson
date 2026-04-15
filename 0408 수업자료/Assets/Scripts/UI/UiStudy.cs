using UnityEngine;
using UnityEngine.UI;

public class UiStudy : MonoBehaviour
{
    [SerializeField] private Text exText;
    [SerializeField] private Image exImage;

    private void Start()
    {
        exText.text = "Hello, World!";
        exText.fontSize = 24;
        
        Debug.Log("Text updated!");
        exImage.color = Color.red;
    }
}
