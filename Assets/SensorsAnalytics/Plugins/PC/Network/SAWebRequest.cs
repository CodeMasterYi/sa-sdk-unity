﻿//

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using SensorsAnalyticsPCSDK.Utils;

    /// <summary>
    public delegate void SAResponseHandle(UnityWebRequest webRequest = null, IList<Dictionary<string, object>> eventDatas = null);

    public class SAWebRequest
            switch (webRequest.result)
                if (webRequest.isHttpError || webRequest.isNetworkError)
                {
                    SALogger.Error("Error response : \n", webRequest.error);
                }
                else
                {
                     SALogger.LogInfo("SAWebRequest RequestData Success: \n", webRequest.downloadHandler.text);
                }
#endif
            responseHandle?.Invoke(webRequest, eventDatas);
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(inputStr);
            using var outputStream = new MemoryStream();
        }

}

