﻿//

namespace SensorsAnalyticsPCSDK.Constant
    {
        NONE = 0,
        ALL = 0xff
    }
    {
        None = 0,
        AppStart = 1 << 0,
        AppEnd = 1 << 1
    }
    {

        public static readonly string kSAEventPresetPropertyLibName = "Unity";

        // 计时后的事件名后缀
        public static readonly string kSAEventIdSuffix = "_SATimer";

        #region 外层属性常量
        // 事件触发时间
        public static readonly string kSAEventTime = "time";

        public static readonly string kSAEventType = "type";

        public static readonly string kSAEventTrackId = "_track_id";

        public static readonly string kSAEventDistinctId = "distinct_id";

        
        public static readonly string kSAEventLoginId = "login_id";

        public static readonly string kSAEventAnonymousId = "anonymous_id";

        public static readonly string kSAEventProperties = "properties";

        public static readonly string kSAEventLib = "lib";

        // 事件名
        public static readonly string kSAEventName = "event";

        #endregion


        // 绑定事件
        public static readonly string kSAEventBind = "$BindID";

        // 解绑事件
        public static readonly string kSAEventUnBind = "$UnbindID";

        // App 版本 & lib

        // 事件时长
        public static readonly string kSAEventDurationProperty = "event_duration";

        // UA
        public static readonly string kSAEventPropertyUserAgent = "$user_agent";

        public static readonly string kSAEventPropertyFirstVisitTime = "$first_visit_time";

        public static readonly string kSAEventPropertyIsFirstTime = "$is_first_time";

        #endregion



        // 自定义 token
        public static readonly string kSAEventPropertyToken = "$token";

        // project 属性，自定义后才包含
        public static readonly string kSAEventProject = "project";

        // token 属性，自定义后才包含
        public static readonly string kSAEventToken = "token";

        // 自定义事件时间
        public static readonly string kSAEventPropertyTime = "$time";

        //神策成立时间，2015-05-15 10:24:00.000，某些时间戳判断（毫秒）
        public static readonly Int64 kSAEventCommonOptionalPropertyTimeInt = 1431656640000;

        #endregion

        #region track type

        /* track type */
        public static readonly string kSAEventTypeTrack = "track";

        public static readonly string kSAEventTypeSignup = "track_signup";

        public static readonly string kSAEventTypeBind = "track_id_bind";

        public static readonly string kSAEventTypeUnbind = "track_id_unbind";

        #endregion

        #region Profile 相关事件

        /* Profile Set */
        public static readonly string kSAProfileSet = "profile_set";

        public static readonly string kSAProfileSetOnce = "profile_set_once";

        public static readonly string kSAProfileUnset = "profile_unset";

        public static readonly string kSAProfileDelete = "profile_delete";

        public static readonly string kSAProfileAppend = "profile_append";

        public static readonly string kSAProfileIncrement = "profile_increment";


        #endregion


        #region 本地文件存储 Key


        /* 数据存储 key */
        public static readonly string kSARandomDeviceIDFileName = "SensorsData_Device_ID";

        #endregion

        #region 特殊常量定义

        //event name、property key、value max length
        public static readonly int kSAEventNameMaxLength = 100;
        // 属性值长度判断
        public static readonly int kSAPropertyValueMaxLength = 1024;

        #endregion

    }

}