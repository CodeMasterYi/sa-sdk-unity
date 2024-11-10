/*
 * Created by 储强盛 on 2023/03/06.
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
using System.Collections.Generic;
using SensorsAnalyticsPCSDK.Builder;
using SensorsAnalyticsPCSDK.Constant;
using SensorsAnalyticsPCSDK.Property;
using SensorsAnalyticsPCSDK.Tracker;
using SensorsAnalyticsPCSDK.Database;
using SensorsAnalyticsPCSDK.Network;
using UnityEngine;
using System.Collections;
{
    public class SensorsAnalyticsSDK
    {

        public static SensorsAnalyticsSDK InstanceSDK;

        private readonly SAIdentifier _identifier = new SAIdentifier();
        private readonly SAPresetPropertyObject _presetPropertyObject = new SAPresetPropertyObject();
        private readonly SASuperProperty _superProperty = new SASuperProperty();
        private readonly SATrackTimer _trackTimer = new SATrackTimer();
        private readonly SAEventStore _eventStore;
        private readonly SAFlush _flushStore;
        private readonly SAConfigOptions _configOptions;
        private readonly MonoBehaviour _SDKMono;
        private readonly SATrackInstallation _trackInstallation = new SATrackInstallation();
        private readonly SAAutoTracker _autoTracker;
        // 定时上传任务协程
        private Coroutine _timedFlushCoroutine;

        public SensorsAnalyticsSDK(SAConfigOptions configOptions, MonoBehaviour mono = null)
            {
                SALogger.Error("SensorsAnalyticsSDK Init Error: " + exception.Message);
            }

        public void Track(string eventName, Dictionary<string, object> properties)

        /// <summary>
        public void ProfileSet(Dictionary<string, object> properties)

        /// <summary>
        public void ProfileSetOnce(Dictionary<string, object> properties)

        public void Login(string loginId)

        public void Logout()

        public void Identify(string anonymousId)

        public string LoginId()

        public string DistinctId()

        public void TrackAppInstall(Dictionary<string, object> properties, bool disableCallback = false)

        internal void TrackEventObject(SABaseEventObject eventObject, Dictionary<string, object> properties)
            {
                SALogger.Error("SensorsAnalyticsSDK TrackEventObject Error: ", ex.Message);
            }

            while (true)
            {
                yield return new WaitForSeconds(_configOptions.FlushInterval);
                Flush();
            }
        }

}
