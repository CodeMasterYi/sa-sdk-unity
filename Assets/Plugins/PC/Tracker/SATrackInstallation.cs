﻿//// Created by 储强盛 on 2023/3/21.// Copyright © 2015-2023 Sensors Data Co., Ltd. All rights reserved.//// Licensed under the Apache License, Version 2.0 (the "License");// you may not use this file except in compliance with the License.// You may obtain a copy of the License at////      http://www.apache.org/licenses/LICENSE-2.0//// Unless required by applicable law or agreed to in writing, software// distributed under the License is distributed on an "AS IS" BASIS,// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.// See the License for the specific language governing permissions and// limitations under the License.//using System;
using System.Collections.Generic;
using SensorsAnalyticsPCSDK.Constant;
using SensorsAnalyticsPCSDK.Database;

namespace SensorsAnalyticsPCSDK.Tracker{    public class SATrackInstallation    {        private readonly string kSAHasTrackInstallation = "SensorsData_HasTrackInstallation";        private readonly string kSAHasTrackInstallationDisableCallback = "SensorsData_HasTrackInstallationWithDisableCallback";              public SATrackInstallation()        {        }        // 是否触发过激活事件        public bool HasTrackInstallation(bool disableCallback)        {            string trackInstallationKey = disableCallback ? kSAHasTrackInstallation : kSAHasTrackInstallationDisableCallback;            return SAFileStore.HasObject(trackInstallationKey);        }        // 触发激活事件        public void TrackInstallation(bool disableCallback)        {            string trackInstallationKey = disableCallback ? kSAHasTrackInstallation : kSAHasTrackInstallationDisableCallback;            SAFileStore.WriteObject(trackInstallationKey, 1);        }        // 获取 Profile 相关属性        public Dictionary<string, object> ProfileProperties()        {            Dictionary<string, object> properties = new Dictionary<string, object>();            properties[SAConstant.kSAEventPropertyFirstVisitTime] = DateTime.Now;            return properties;        }    }
}


