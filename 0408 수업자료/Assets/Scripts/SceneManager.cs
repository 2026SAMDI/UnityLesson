using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneLoader : MonoBehaviour
{
    public void OnclickLoadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
