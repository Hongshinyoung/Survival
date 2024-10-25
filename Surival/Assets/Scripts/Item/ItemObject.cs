using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public string GetInteractPrompt(); //화면에 보여줄
    public void OnInteract(); //상호작용
}

public class ItemObject : MonoBehaviour, IInteractable
{
    public ItemData data;

    public string GetInteractPrompt()
    {
        string str = $"{data.displayName}\n{data.description}";
        return str;
    }

    public void OnInteract()
    {
        CharacterManager.Instance.Player.itemData = data;
        CharacterManager.Instance.Player.addItem?.Invoke();
        Destroy(gameObject); //줍기하니까 맵에선 삭제
    }
}
