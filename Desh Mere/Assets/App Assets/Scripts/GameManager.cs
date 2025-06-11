using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<GameObject> panels = new List<GameObject>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        OpenMenu(3);
    }

    public void OpenMenu(int index)
    {
        foreach(var obj in  panels)
        {
            var getComponentCanvasGroup = obj.GetComponent<CanvasGroup>();
            getComponentCanvasGroup.alpha = 0;
            getComponentCanvasGroup.interactable = false;
            getComponentCanvasGroup.blocksRaycasts = false;

            var getCompCanvasGroupObj2 = panels[index].GetComponent<CanvasGroup>();
            getCompCanvasGroupObj2.alpha = 1;
            getCompCanvasGroupObj2.interactable = true;
            getCompCanvasGroupObj2.blocksRaycasts = true;
        }
    }
}