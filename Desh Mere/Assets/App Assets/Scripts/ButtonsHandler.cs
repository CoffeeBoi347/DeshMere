using UnityEngine;

public class ButtonsHandler : MonoBehaviour
{
    public void OpenHomeMenu()
    {
        GameManager.instance.OpenMenu(0);
    }

    public void OpenNotificationsMenu()
    {
        GameManager.instance.OpenMenu(2);
    }

    public void OpenUserSettingsMenu()
    {
        GameManager.instance.OpenMenu(3);
    }

    public void OpenCreatePostMenu()
    {
        GameManager.instance.OpenMenu(1);
    }
}