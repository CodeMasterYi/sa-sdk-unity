﻿//// Created by 储强盛 on 2023/3/21.// Copyright © 2015-2023 Sensors Data Co., Ltd. All rights reserved.//// Licensed under the Apache License, Version 2.0 (the "License");// you may not use this file except in compliance with the License.// You may obtain a copy of the License at////      http://www.apache.org/licenses/LICENSE-2.0//// Unless required by applicable law or agreed to in writing, software// distributed under the License is distributed on an "AS IS" BASIS,// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.// See the License for the specific language governing permissions and// limitations under the License.//using System;
using System.Collections.Generic;
using SensorsAnalyticsPCSDK.Utils;
using SensorsAnalyticsPCSDK.Main;

namespace SensorsAnalyticsPCSDK.Database{

    public class SAEventStore    {        private readonly SADatabase _database = new SADatabase();
        private readonly SAConfigOptions _configOptions;
        // 静态对象作为锁，防止本地数据多线程读写问题        private readonly static object s_lockObject = new object();        public SAEventStore(SAConfigOptions configOptions)        {            _configOptions = configOptions;        }        /// <summary>        ///  事件入库        /// </summary>        /// <param name="eventInfo">事件数据</param>        /// <returns>当前数据条数</returns>        public int InsertEventInfo(Dictionary<string, object>eventInfo)        {            int recordCount = 0;            lock(s_lockObject)            {                int currentCount = _database.EventRecordCount();                while(currentCount >= _configOptions.MaxCacheSize)                {                    SALogger.Warn($"The number of current events is too large, The maximum storage limit has been exceeded {_configOptions.MaxCacheSize}, Deleting 100 records and storing the latest event record");                    currentCount = _database.DeleteFirstRecords(100);                }                recordCount = _database.InsertEventInfo(eventInfo);            }            return recordCount;        }        /// <summary>        /// 删除前面固定条数事件记录        /// </summary>        /// <param name="recordCount"></param>        public int DeleteFirstRecords(int recordCount)        {            lock (s_lockObject)            {              return  _database.DeleteFirstRecords(recordCount);            }                    }        /// <summary>        /// 删除所有事件记录        /// </summary>        public void DeleteAllRecords()        {            lock (s_lockObject)            {                _database.DeleteAllRecords();            }        }        /// <summary>        /// 读取指定条数的事件记录        /// </summary>        /// <param name="recordCount"></param>        /// <returns></returns>        public List<Dictionary<string, object>> SelectEventRecords(int recordCount)        {            lock (s_lockObject)            {                return _database.SelectEventRecords(recordCount);            }        }    }

}

