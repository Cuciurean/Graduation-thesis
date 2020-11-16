using UnityEngine;
using System.Collections;
using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Linq;
using System.Configuration;
using UnityEditor;

public class PostNewTrackableRequest
{
    public string name;
    public float width;
    public string image;
    public string application_metadata;
}

/// <summary>
///Clasa rsponsabila pebtru incarcarea imaginilor in baza de date cloud
/// </summary>
public class CloudUpLoading : MonoBehaviour
{

    public Texture2D texture;
    
    //Key de acces de la baza de date
    private string access_key = "104732711d2a609b11064fd0ebb2cfb1d8f8fb66";
    private string secret_key = "b3aed02c489480d8694a73e27310f31395e9d602";
    private string url = @"https://vws.vuforia.com";//@"<a href="https://vws.vuforia.com";//">https://vws.vuforia.com";</a>
    private string targetName = "P0000" ; 
    
    
    private byte[] requestBytesArray;

    public void CallPostTarget()
    {
        StartCoroutine (PostNewTarget());
    }

    //Incarcare imagine noua
    IEnumerator PostNewTarget()
    {
        
        string requestPath = "/targets";
        string serviceURI = url + requestPath;
        string httpAction = "POST";
        string contentType = "application/json";
        string date = string.Format("{0:r}", DateTime.Now.ToUniversalTime());
    
        Debug.Log(date);
    
        // Daca este de format RGB textura nu trebuie modificata
        Texture2D tex = new Texture2D(texture.width,texture.height,TextureFormat.RGB24,false);
        tex.SetPixels(texture.GetPixels());
        tex.Apply();
        byte[] image = tex.EncodeToPNG();
   
        string metadataStr = "Vuforia metadata";
        byte[] metadata = System.Text.ASCIIEncoding.ASCII.GetBytes(metadataStr);

        //Se creeaza un model nou de imagine
        PostNewTrackableRequest model = new PostNewTrackableRequest();
        model.name = targetName;
        model.width = 64.0f; 
        model.image = System.Convert.ToBase64String(image);


        model.application_metadata = System.Convert.ToBase64String(metadata);
        string requestBody = JsonUtility.ToJson(model);
        WWWForm form = new WWWForm ();
    
        var headers = form.headers;
        byte[] rawData = form.data;
        headers[ "host"]=url;
        headers["date"] = date;
        headers["Content-Type"]= contentType;
    
        //Cerere de la server
        HttpWebRequest httpWReq = (HttpWebRequest)HttpWebRequest.Create(serviceURI);
    
        MD5 md5 = MD5.Create();
        var contentMD5bytes = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(requestBody));
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        for (int i = 0; i < contentMD5bytes.Length; i++)
        {
            sb.Append(contentMD5bytes[i].ToString("x2"));
        }
    
        string contentMD5 = sb.ToString();
    
        string stringToSign = string.Format("{0}\n{1}\n{2}\n{3}\n{4}", httpAction, contentMD5, contentType, date, requestPath);
    
        HMACSHA1 sha1 = new HMACSHA1(System.Text.Encoding.ASCII.GetBytes(secret_key));
        byte[] sha1Bytes = System.Text.Encoding.ASCII.GetBytes(stringToSign);
        MemoryStream stream = new MemoryStream(sha1Bytes);
        byte[] sha1Hash = sha1.ComputeHash(stream);
        string signature = System.Convert.ToBase64String(sha1Hash);
    
        headers["Authorization"]=string.Format("VWS {0}:{1}", access_key, signature);
    
        Debug.Log("<color=green>Signature: "+signature+"</color>");
    
        WWW request =new WWW(serviceURI,System.Text.Encoding.UTF8.GetBytes(JsonUtility.ToJson(model)), headers);
        yield return request;

        //AssetDatabase.Refresh();

        if (request.error != null)
        {
            Debug.Log("request error: " + request.error);
        }
        else
        {
            Debug.Log("request success");
            Debug.Log("returned data" + request.text);
        }
        //AssetDatabase.Refresh();
    }
}
