﻿//
using System.Collections.Generic;


        /// <summary>
        /// 将字典转换成 Json 字符串
        /// </summary>
        /// <param name="dictionary">字典</param>
        /// <returns>json 字符串，如果字典不能转换成字符串那么会返回 null。</returns>
        public static string StringWithJSONObject(object obj)
        {
            if (obj == null)
            {
                return null;
            }
            try
            {
                return SAJSON.Serialize(obj);
            }
            catch (Exception e)
            {
                SALogger.Error(e.Message);
            }
            return null;
        }

        /// <summary>
        /// 将 json 字符串转换成字典
        /// </summary>
        /// <param name="jsonStr"></param>
        /// <returns>字典对象，如果不能转换则返回 null。</returns>
        public static Dictionary<string, object> JSONObjectWithString(string jsonStr)
        {
            if (string.IsNullOrEmpty(jsonStr))
            {
                return null;
            }
            try
            {
                return SAJSON.Deserialize(jsonStr) as Dictionary<string, object>;
            }
            catch (Exception ex)
            {
                SALogger.Error(ex.Message);
            }
            return null;
        }

	}

}
