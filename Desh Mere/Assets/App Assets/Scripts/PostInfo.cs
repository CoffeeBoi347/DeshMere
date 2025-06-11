using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PostInfo : MonoBehaviour
{
    public Image postImageRef;
    public TMP_Text postCaption;
    public TMP_Text postTitle;

    public Sprite postImage;
    public Button postLikes;
    public Button postDislikes;
    public Button postComments;

    public int postLikesAmnt;
    public int postDislikesAmnt;
    public TMP_Text postLikesTxt;
    public TMP_Text postDislikesTxt;

    private void Start()
    {
        postLikes.onClick.AddListener(IncreasePostLikes);
        postDislikes.onClick.AddListener(IncreasePostDislikes);
        SetValues();
    }

    public void SetValues()
    {
        if (postImageRef != null && postImage != null)
        {
            // to do with scriptable objects
        }
    }

    public void IncreasePostLikes()  
    {
        postLikesAmnt++;
        postLikesTxt.text = postLikesAmnt.ToString();
    }

    public void IncreasePostDislikes()
    {
        postDislikesAmnt++;
        postDislikesTxt.text = postDislikesAmnt.ToString();
    }
}