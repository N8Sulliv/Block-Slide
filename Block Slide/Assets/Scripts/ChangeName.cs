using UnityEngine.UI;
using UnityEngine;

public class ChangeName : MonoBehaviour
{
    public Text Player;
    public Text name;
    public void NameChanged()
    {
        Player.text = name.text;
    }
}
