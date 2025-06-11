using System.Collections.Generic;
using UnityEngine;

public class ViewPosts : MonoBehaviour
{
    public List<PostScriptableObj> posts = new List<PostScriptableObj>();
    public GameObject postObj;
    public GameObject postObjParent;

    private void Start()
    {
        RandomizePosts(posts);
        OpenPosts();
        Debug.Log("OPENING ALL!");
    }

    public void OpenPosts()
    {
        foreach (var postDataObj in posts)
        {
            GameObject post = Instantiate(postObj, postObjParent.transform);
            PostData data = post.GetComponent<PostData>();

            data.userName = postDataObj.userName;
            data.userCaption = postDataObj.userCaption;
            data.addressLine = postDataObj.addressLine;
            data.axisAddress = postDataObj.axisAddress;
            data.userMessage = postDataObj.userMessage;
            data.existingLikes = postDataObj.existingLikes;
            data.existingDislikes = postDataObj.existingDislikes;
            data.imageObj = postDataObj.imageObj;

            data.Init();
        }
    }

    public void RandomizePosts(List<PostScriptableObj> listObj)
    {
        for(int i = 0; i < listObj.Count; i++)
        {
            var randomVal = Random.Range(0, listObj.Count);
            var temp = listObj[i];
            listObj[i] = listObj[randomVal];
            listObj[randomVal] = temp;
        }
    }
}
