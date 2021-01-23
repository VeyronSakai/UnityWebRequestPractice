using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public class MainController : MonoBehaviour
{
    private const string TruthUri = "http://localhost:8080/truth";
    private const string LieUri = "http://localhost:8080/lie";
    private const string StartUri = "https://talpidae-backend.herokuapp.com/start";

    private async void Start()
    {
        // await RequestAsync();
        await RequestStartAsync();
    }

    private static async UniTask RequestAsync()
    {
        var webRequest = UnityWebRequest.Get(LieUri);

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

    private static async UniTask RequestStartAsync()
    {
        var webRequest = UnityWebRequest.Get(StartUri);

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