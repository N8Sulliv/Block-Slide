using UnityEngine.UI;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    public void Changed(float f)
    {
        GetComponent<Text>().text = f.ToString("0.01") + " x";
    }
}
