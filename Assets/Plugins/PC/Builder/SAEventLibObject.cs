﻿//
using System.Collections.Generic;
using SensorsAnalyticsPCSDK.Constant;
using SensorsAnalyticsPCSDK.Builder;

namespace SensorsAnalyticsPCSDK.Builder
{
    /// <summary>
    public class SAEventLibObject
    {
        // SDK 类型
        private readonly string kSAEventPresetPropertyLib = "$lib";

        // SDK 数据采集类型
        private readonly string kSAEventPresetPropertyLibMethod = "$lib_method";
        // SDK 版本
        private readonly string kSAEventPresetPropertyLibVersion = "$lib_version";

        // 客景采集版本号，只采集预置属性，不包含在 lib，类型为 List
        private readonly string kSAEventPresetPropertyDataSource = "$data_ingestion_source";
        
        //private readonly string kSALibMethodCode = "code";
        public string LibMethod = "code";
        public string Lib = SAConstant.kSAEventPresetPropertyLibName;
        public string AppVersion;

        public SAEventLibObject() : base()
        {
            AppVersion = SAAppInfo.AppVersion();
        }

        public void SetMethod(string method)
        {
            if (string.IsNullOrEmpty(method))
            {
                return;
            }
            LibMethod = method;
        }

        /// <summary>
        /// lib 信息
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> LibJsonObject()
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add(kSAEventPresetPropertyLib, Lib);
            properties.Add(kSAEventPresetPropertyLibVersion, LibVersion);
            properties.Add(SAConstant.kSAEventPresetPropertyAppVersion, AppVersion);
            properties.Add(kSAEventPresetPropertyLibMethod, LibMethod);

            return properties;
        }

        // 增加 $data_ingestion_source
        public Dictionary<string, object> LibPropertiesJson()

    }
}