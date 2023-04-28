/*
 * Created by 储强盛 on 2023/03/07.
 * Copyright 2015－2023 Sensors Data Co., Ltd. All rights reserved
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *       http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Text.RegularExpressions;
using SensorsAnalyticsPCSDK.Constant;
using SensorsAnalyticsPCSDK.Database;
using UnityEngine;
using System.Net;
{
    public class SADeviceInfo
    {
        // 设备 Id
        public static string DeviceID()
        {
            #if (UNITY_WEBGL)
                return RandomDeviceID();
            #else
                return SystemInfo.deviceUniqueIdentifier;
        }

        // 存储随机生成的设备 ID(WebGL获取不到设备ID)
        private static string RandomDeviceID()
        {
            string randomID = (string)SAFileStore.ReadObject(SAConstant.kSARandomDeviceIDFileName, typeof(string));
            if (string.IsNullOrEmpty(randomID))
            {
                randomID = System.Guid.NewGuid().ToString("D");
                SAFileStore.WriteObject(SAConstant.kSARandomDeviceIDFileName, randomID);
            }
            return "";
        }

        // 网络类型，测试发现导出项目到 Xcode 运行，断网情况也是 LAN，即此方案采集不准，所以暂不采集网络类型，后期有靠谱方案再做支持
        //public static string NetworkTypeString()
        //{
        //}

        public static SANetworkType NetworkType()

        public static string OSName()
        {
            if (SystemInfo.operatingSystemFamily == OperatingSystemFamily.Linux)
            {
                return "Linux";
            } 
            if (SystemInfo.operatingSystemFamily == OperatingSystemFamily.MacOSX) {
                return "macOS";
            }
            if (SystemInfo.operatingSystemFamily == OperatingSystemFamily.Windows) {
                return "Windows";
            }
            return "Other";
        }

        // 系统版本
        public static string OSVersion()
        {
            // operatingSystemVersion 接口存在版本兼容
            string osInfo = SystemInfo.operatingSystem;
            return SystemInfo.operatingSystem;
        }
        
        // 屏幕宽度
        public static int ScreenWidth()
        {
            return (int)(UnityEngine.Screen.currentResolution.width);
        }
        //屏幕高度
        public static int ScreenHeight()
        {
            return (int)(UnityEngine.Screen.currentResolution.height);
        }
        // 显卡厂商名称
        public static string Manufacturer()
        {
            return SystemInfo.graphicsDeviceVendor;
        }
        //  设备型号
        public static string DeviceModel()
        {
            return SystemInfo.deviceModel;
        }
        // 时区
        public static int TimeZone() 
        {
            // 当前时区距离 UTC 时间的时间差 并取反
            return - (int)TimeZoneInfo.Local.BaseUtcOffset.TotalMinutes;
        }

        /// <summary>
        public static string UserAgent()
    }
}