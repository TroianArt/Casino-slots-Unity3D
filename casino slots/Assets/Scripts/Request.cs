using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class Request : MonoBehaviour
{
    public Text requestText1;
    public Text requestText2;
    void Start()
    {
        StartCoroutine(GetRequest("http://unity3d.com/",requestText1));
        StartCoroutine(GetRequest("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json", requestText2));

    }
    
    IEnumerator GetRequest(string uri,Text text)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(uri);
        yield return uwr.SendWebRequest();
        if (uwr.isNetworkError)
        {
            text.text = text.text+" error";
        }
        else
        {
            text.text = text.text+" OK";
        }
        string a = System.Text.Encoding.UTF8.GetString(uwr.downloadHandler.data);
        Debug.Log(a);
    }
}
