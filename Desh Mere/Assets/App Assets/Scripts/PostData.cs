using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PostData : MonoBehaviour
{
    public Sprite imageObj;
    public string userName;
    public string userCaption;
    public string userMessage;
    public string addressLine;
    public string axisAddress;
    public int existingLikes;
    public int existingDislikes;
    public Image userImageObj;
    [Header("Text Values")]

    public TMP_Text _userNameTxt;
    public TMP_Text _userMessageTxt;
    public TMP_Text _userCaptionTxt;
    public TMP_Text _addressLineTxt;
    public TMP_Text _axisAddressTxt;
    public TMP_Text _existingLikesTxt;
    public TMP_Text _existingDislikesTxt;

    [Header("Buttons")]

    public Button likeButton;
    public Button dislikeButton;

    public void Init()
    {
        _userNameTxt.text = userName;
        _userMessageTxt.text = userMessage;
        _userCaptionTxt.text = userCaption;
        userImageObj.sprite = imageObj;
        _addressLineTxt.text = addressLine;
        _axisAddressTxt.text = axisAddress;

        _existingLikesTxt.text = existingLikes.ToString();
        _existingDislikesTxt.text = existingDislikes.ToString();
    }
}