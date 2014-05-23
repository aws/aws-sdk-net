/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WeeklyAutoScalingSchedule Object
    /// </summary>  
    public class WeeklyAutoScalingScheduleUnmarshaller : IUnmarshaller<WeeklyAutoScalingSchedule, XmlUnmarshallerContext>, IUnmarshaller<WeeklyAutoScalingSchedule, JsonUnmarshallerContext>
    {
        WeeklyAutoScalingSchedule IUnmarshaller<WeeklyAutoScalingSchedule, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public WeeklyAutoScalingSchedule Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new WeeklyAutoScalingSchedule();
            unmarshalledObject.Friday = null;
            unmarshalledObject.Monday = null;
            unmarshalledObject.Saturday = null;
            unmarshalledObject.Sunday = null;
            unmarshalledObject.Thursday = null;
            unmarshalledObject.Tuesday = null;
            unmarshalledObject.Wednesday = null;
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("Friday", targetDepth))
                    {
                        unmarshalledObject.Friday = new Dictionary<string, string>();
                        var unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                        while (context.Read())
                        {
                          if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                              ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                          {
                            var kvp = unmarshaller.Unmarshall(context);
                            unmarshalledObject.Friday.Add(kvp.Key, kvp.Value);
                          }
                          else if (context.IsEndElement)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("Monday", targetDepth))
                    {
                        unmarshalledObject.Monday = new Dictionary<string, string>();
                        var unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                        while (context.Read())
                        {
                          if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                              ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                          {
                            var kvp = unmarshaller.Unmarshall(context);
                            unmarshalledObject.Monday.Add(kvp.Key, kvp.Value);
                          }
                          else if (context.IsEndElement)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("Saturday", targetDepth))
                    {
                        unmarshalledObject.Saturday = new Dictionary<string, string>();
                        var unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                        while (context.Read())
                        {
                          if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                              ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                          {
                            var kvp = unmarshaller.Unmarshall(context);
                            unmarshalledObject.Saturday.Add(kvp.Key, kvp.Value);
                          }
                          else if (context.IsEndElement)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("Sunday", targetDepth))
                    {
                        unmarshalledObject.Sunday = new Dictionary<string, string>();
                        var unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                        while (context.Read())
                        {
                          if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                              ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                          {
                            var kvp = unmarshaller.Unmarshall(context);
                            unmarshalledObject.Sunday.Add(kvp.Key, kvp.Value);
                          }
                          else if (context.IsEndElement)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("Thursday", targetDepth))
                    {
                        unmarshalledObject.Thursday = new Dictionary<string, string>();
                        var unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                        while (context.Read())
                        {
                          if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                              ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                          {
                            var kvp = unmarshaller.Unmarshall(context);
                            unmarshalledObject.Thursday.Add(kvp.Key, kvp.Value);
                          }
                          else if (context.IsEndElement)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("Tuesday", targetDepth))
                    {
                        unmarshalledObject.Tuesday = new Dictionary<string, string>();
                        var unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                        while (context.Read())
                        {
                          if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                              ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                          {
                            var kvp = unmarshaller.Unmarshall(context);
                            unmarshalledObject.Tuesday.Add(kvp.Key, kvp.Value);
                          }
                          else if (context.IsEndElement)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("Wednesday", targetDepth))
                    {
                        unmarshalledObject.Wednesday = new Dictionary<string, string>();
                        var unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                        while (context.Read())
                        {
                          if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                              ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                          {
                            var kvp = unmarshaller.Unmarshall(context);
                            unmarshalledObject.Wednesday.Add(kvp.Key, kvp.Value);
                          }
                          else if (context.IsEndElement)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }


        private static WeeklyAutoScalingScheduleUnmarshaller instance;
        public static WeeklyAutoScalingScheduleUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new WeeklyAutoScalingScheduleUnmarshaller();
            }
            return instance;
        }

    }
}