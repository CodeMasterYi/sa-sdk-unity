﻿//
using System.Collections.Generic;
using SensorsAnalyticsPCSDK.Constant;
    public class SATrackEventObject: SABaseEventObject
	{
		/// <summary>
		public SATrackEventObject(string eventId): base()
		{
            if(eventId is string)
		}
            {
            }
            {
              this.Properties[kvp.Key] = kvp.Value;
            }
            // 从公共属性中更新 lib 节点中的 $app_version 值
            if(properties.ContainsKey(SAConstant.kSAEventPresetPropertyAppVersion))
        }


        /// <summary>
            {
                this.Properties[SAConstant.kSAEventDurationProperty] = duration;
            }


        /// <summary>

        public override Dictionary<string, object>JsonObject()
            foreach (KeyValuePair<string, object> kvp in libProperties)
            {
            }
	}

