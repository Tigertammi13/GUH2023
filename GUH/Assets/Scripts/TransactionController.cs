using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using UnityEditor.ShaderGraph.Serialization;
using UnityEngine;
using TMPro;
//using static UnityEngine.JsonUtility;
//using static TransactionObject;
//using System;
//using System.Threading.Tasks;
using UnityEngine.Networking;

public class TransactionController: MonoBehaviour
{
    public string name;
    public float balance;
    public long accountNumber;
    TextMeshPro nameUnity;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        //JsonObject jsonObject = new JsonObject();
        //HttpClient client = new HttpClient();
        //client.DefaultRequestHeaders.Authorization =
        //    new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJuYmYiOjE2OTYwMzIwMDAsImFwaV9zdWIiOiI1ZmNjZWM0MjJiMDJiZjZkZTk5ZjgzODRkZmEwN2ZhNDUzNmRkM2ZlYjM1NDkxNDE0ZTYwNDVmZThkNTg0MzNjMTcxNzIwMDAwMDAwMCIsInBsYyI6IjVkY2VjNzRhZTk3NzAxMGUwM2FkNjQ5NSIsImV4cCI6MTcxNzIwMDAwMCwiZGV2ZWxvcGVyX2lkIjoiNWZjY2VjNDIyYjAyYmY2ZGU5OWY4Mzg0ZGZhMDdmYTQ1MzZkZDNmZWIzNTQ5MTQxNGU2MDQ1ZmU4ZDU4NDMzYyJ9.Q4lVGHaQpKrlO59t0uD3eZ1ANHbw1PDJKa-t20jisyh1c5ZeBpDFT48YUGLNe9pK4VmEa2p2METdIqkRQo2i0u-ain7aL4sgJGLo3FLB3vHdlLm6zejr0-xyEuN_yXk0Kw_IOUN7cuj7Bz2M7EZTpqa18Z4KtGaJNRkGx89vvK3DalH8-ybcook-dFuygaKXFPXq0-YN3DwLYwQRbTx5KWRym2-_SHx3DwFyrScIKEvNwGcCcAECZKPmNjT-Lg_8w5UU4FHusoTtmB5_cW0KRlx1UYW59mCcky5RpNFtaaHBv35B8skocAQBmfBD0F-BOn18SDC2akVKJTQeGPnd1g");
        //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //var response = client.GetAsync(string.Format("https://sandbox.capitalone.co.uk/developer-services-platform-pr/api/data/accounts"));
        //var responseMsg = response.Result.Content.ToString();

        string url = "https://sandbox.capitalone.co.uk/developer-services-platform-pr/api/data";

        string bearerToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJuYmYiOjE2OTYwMzIwMDAsImFwaV9zdWIiOiI1ZmNjZWM0MjJiMDJiZjZkZTk5ZjgzODRkZmEwN2ZhNDUzNmRkM2ZlYjM1NDkxNDE0ZTYwNDVmZThkNTg0MzNjMTcxNzIwMDAwMDAwMCIsInBsYyI6IjVkY2VjNzRhZTk3NzAxMGUwM2FkNjQ5NSIsImV4cCI6MTcxNzIwMDAwMCwiZGV2ZWxvcGVyX2lkIjoiNWZjY2VjNDIyYjAyYmY2ZGU5OWY4Mzg0ZGZhMDdmYTQ1MzZkZDNmZWIzNTQ5MTQxNGU2MDQ1ZmU4ZDU4NDMzYyJ9.Q4lVGHaQpKrlO59t0uD3eZ1ANHbw1PDJKa-t20jisyh1c5ZeBpDFT48YUGLNe9pK4VmEa2p2METdIqkRQo2i0u-ain7aL4sgJGLo3FLB3vHdlLm6zejr0-xyEuN_yXk0Kw_IOUN7cuj7Bz2M7EZTpqa18Z4KtGaJNRkGx89vvK3DalH8-ybcook-dFuygaKXFPXq0-YN3DwLYwQRbTx5KWRym2-_SHx3DwFyrScIKEvNwGcCcAECZKPmNjT-Lg_8w5UU4FHusoTtmB5_cW0KRlx1UYW59mCcky5RpNFtaaHBv35B8skocAQBmfBD0F-BOn18SDC2akVKJTQeGPnd1g";

        UnityWebRequest request = UnityWebRequest.Get(url);
        request.SetRequestHeader("Authorization", "Bearer " + bearerToken);
        request.SetRequestHeader("Content-Type", "application/json");

        yield return request.SendWebRequest();

        Debug.Log(request.result);

        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError(request.error);
        }
        else
        {
            Debug.Log(request.downloadHandler.text);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
