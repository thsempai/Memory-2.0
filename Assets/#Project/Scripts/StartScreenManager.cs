using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StartScreenManager : MonoBehaviour
{
    [SerializeField] private Button leftButton;
    [SerializeField] private Button midButton;
    [SerializeField] private Button rightButton;

    private void AddListenerTo(Button button, UnityAction action)
    {
        button.onClick.AddListener(action);
        Debug.Log($"{button.name}");
    }

    public void AddListenerToLeft(UnityAction action) => AddListenerTo(leftButton, action);
    public void AddListenerToMiddle(UnityAction action) => AddListenerTo(midButton, action);
    public void AddListenerToRight(UnityAction action) => AddListenerTo(rightButton, action);

}
