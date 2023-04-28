﻿// Created by 储强盛 on 2023/3/9.

using System;
using System.Collections;
    // 日志打印
    public class SALogger
            var className = frame.GetMethod().DeclaringType.Name;
            var method = frame.GetMethod().Name;
            var line = frame.GetFileLineNumber();

            string logInfo = $"{s_prefixLogger} + [{time}] [{file}] [{className} {method}] ({line})\n";

            // 遍历可变参数数组中的每个对象
            foreach (var obj in objs)
            {
                // 如果对象是 Dictionary 类型，则序列化为 JSON 格式，并且设置 Formatting.Indented 选项来换行显示
                if (obj is IDictionary)
                {
                    // JsonConvert.SerializeObject(obj, Formatting.Indented);
                    var json = SAJSONUtils.StringWithJSONObject(obj);
                    logInfo += json;
                }
                // 对象如果是 list 类型，遍历判断每个元素，再判断处理
                else if (obj is IList)
                else
                {
                    // 否则直接输出对象的字符串表示形式
                    logInfo += obj;
                }
            }
            var className = frame.GetMethod().DeclaringType.Name;
            var method = frame.GetMethod().Name;
            var line = frame.GetFileLineNumber();

            string logInfo = $"{s_prefixLogger} + [{time}] [{file}] [{className} {method}] ({line})";
}


