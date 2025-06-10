using UnityEngine;
[CreateAssetMenu(fileName = "PostObj", menuName = "Posts", order = 1)]

public class PostScriptableObj : ScriptableObject
{
    public Sprite imageObj;
    public string userName;
    public string userMessage;
    public string addressLine;
    public string axisAddress;
    public int existingLikes;
    public int existingDislikes;
}