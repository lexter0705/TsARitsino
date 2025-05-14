using UnityEngine;

public class GithubOpener : MonoBehaviour
{
    [SerializeField] private string url;

    public void OpenGithub()
    {
        Debug.Log(url);
        Application.OpenURL(url);
    }
}
