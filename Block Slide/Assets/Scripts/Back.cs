using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public void BackToStart()
    {
        SceneManager.LoadScene("Start");
    }
}
