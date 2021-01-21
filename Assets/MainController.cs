using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public class MainController : MonoBehaviour
{
    private const string URL = "http://localhost:8080/hoge";

    private async void Start()
    {
        await RequestAsync();
    }

    private static async UniTask RequestAsync()
    {
        var webRequest = UnityWebRequest.Get(URL);

        await webRequest.SendWebRequest();

        if (webRequest.result == UnityWebRequest.Result.ConnectionError)
        {
            //通信失敗
            Debug.Log(webRequest.error);
        }
        else
        {
            //通信成功
            Debug.Log(webRequest.downloadHandler.text);
        }
    }
}