/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System.Collections.Generic;

using Amazon.CloudWatch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   AlarmHistoryItem Unmarshaller
     /// </summary>
    internal class AlarmHistoryItemUnmarshaller : IUnmarshaller<AlarmHistoryItem, XmlUnmarshallerContext>, IUnmarshaller<AlarmHistoryItem, JsonUnmarshallerContext> 
    {
        public AlarmHistoryItem Unmarshall(XmlUnmarshallerContext context) 
        {
            AlarmHistoryItem alarmHistoryItem = new AlarmHistoryItem();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("AlarmName", targetDepth))
                    {
                        alarmHistoryItem.AlarmName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Timestamp", targetDepth))
                    {
                        alarmHistoryItem.Timestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("HistoryItemType", targetDepth))
                    {
                        alarmHistoryItem.HistoryItemType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("HistorySummary", targetDepth))
                    {
                        alarmHistoryItem.HistorySummary = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("HistoryData", targetDepth))
                    {
                        alarmHistoryItem.HistoryData = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return alarmHistoryItem;
                }
            }
                        


            return alarmHistoryItem;
        }

        public AlarmHistoryItem Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static AlarmHistoryItemUnmarshaller instance;

        public static AlarmHistoryItemUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new AlarmHistoryItemUnmarshaller();

            return instance;
        }
    }
}
    
