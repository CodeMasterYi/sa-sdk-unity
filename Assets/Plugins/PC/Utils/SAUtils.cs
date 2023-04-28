﻿//
using System.Collections.Generic;
using System.Text;

namespace SensorsAnalyticsPCSDK.Utils
    public class SAUtils
	{

		/// <summary>
        public static string ToDebugString(Dictionary<string, object> dictionary)
        {
            if (dictionary == null)
            {
                return null;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (var item in dictionary)
            {
                sb.Append("").Append(item.Key).Append(",").Append(item.Value).Append("),");
            }
            sb.Append("]");
            return sb.ToString();
        }

        /// <summary>
        public static string Base64EncodingString(string inputStr)
            string base64Str = System.Convert.ToBase64String(bytes);

        /// <summary>
        public static string Base64DecodingString(string base64Str)
            string originStr = System.Text.Encoding.UTF8.GetString(bytes);

	}
}

