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
    using System;
    using System.Collections.Generic;
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// WeeklyAutoScalingScheduleUnmarshaller
      /// </summary>
      internal class WeeklyAutoScalingScheduleUnmarshaller : IUnmarshaller<WeeklyAutoScalingSchedule, XmlUnmarshallerContext>, IUnmarshaller<WeeklyAutoScalingSchedule, JsonUnmarshallerContext>
      {
        WeeklyAutoScalingSchedule IUnmarshaller<WeeklyAutoScalingSchedule, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WeeklyAutoScalingSchedule Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            WeeklyAutoScalingSchedule weeklyAutoScalingSchedule = new WeeklyAutoScalingSchedule();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("Monday", targetDepth))
              {
                context.Read();
                weeklyAutoScalingSchedule.Monday = new Dictionary<String,String>();
                KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;
                  if (token == JsonToken.ArrayStart || token == JsonToken.ObjectStart)
                  {
                      continue;
                  }
                  if (token == JsonToken.ArrayEnd || token == JsonToken.ObjectEnd)
                  {
                      break;
                  }
                  KeyValuePair<string, string> kvp = unmarshaller.Unmarshall(context);
                    weeklyAutoScalingSchedule.Monday.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
              if (context.TestExpression("Tuesday", targetDepth))
              {
                context.Read();
                weeklyAutoScalingSchedule.Tuesday = new Dictionary<String,String>();
                KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;
                  if (token == JsonToken.ArrayStart || token == JsonToken.ObjectStart)
                  {
                      continue;
                  }
                  if (token == JsonToken.ArrayEnd || token == JsonToken.ObjectEnd)
                  {
                      break;
                  }
                  KeyValuePair<string, string> kvp = unmarshaller.Unmarshall(context);
                    weeklyAutoScalingSchedule.Tuesday.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
              if (context.TestExpression("Wednesday", targetDepth))
              {
                context.Read();
                weeklyAutoScalingSchedule.Wednesday = new Dictionary<String,String>();
                KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;
                  if (token == JsonToken.ArrayStart || token == JsonToken.ObjectStart)
                  {
                      continue;
                  }
                  if (token == JsonToken.ArrayEnd || token == JsonToken.ObjectEnd)
                  {
                      break;
                  }
                  KeyValuePair<string, string> kvp = unmarshaller.Unmarshall(context);
                    weeklyAutoScalingSchedule.Wednesday.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
              if (context.TestExpression("Thursday", targetDepth))
              {
                context.Read();
                weeklyAutoScalingSchedule.Thursday = new Dictionary<String,String>();
                KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;
                  if (token == JsonToken.ArrayStart || token == JsonToken.ObjectStart)
                  {
                      continue;
                  }
                  if (token == JsonToken.ArrayEnd || token == JsonToken.ObjectEnd)
                  {
                      break;
                  }
                  KeyValuePair<string, string> kvp = unmarshaller.Unmarshall(context);
                    weeklyAutoScalingSchedule.Thursday.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
              if (context.TestExpression("Friday", targetDepth))
              {
                context.Read();
                weeklyAutoScalingSchedule.Friday = new Dictionary<String,String>();
                KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;
                  if (token == JsonToken.ArrayStart || token == JsonToken.ObjectStart)
                  {
                      continue;
                  }
                  if (token == JsonToken.ArrayEnd || token == JsonToken.ObjectEnd)
                  {
                      break;
                  }
                  KeyValuePair<string, string> kvp = unmarshaller.Unmarshall(context);
                    weeklyAutoScalingSchedule.Friday.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
              if (context.TestExpression("Saturday", targetDepth))
              {
                context.Read();
                weeklyAutoScalingSchedule.Saturday = new Dictionary<String,String>();
                KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;
                  if (token == JsonToken.ArrayStart || token == JsonToken.ObjectStart)
                  {
                      continue;
                  }
                  if (token == JsonToken.ArrayEnd || token == JsonToken.ObjectEnd)
                  {
                      break;
                  }
                  KeyValuePair<string, string> kvp = unmarshaller.Unmarshall(context);
                    weeklyAutoScalingSchedule.Saturday.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
              if (context.TestExpression("Sunday", targetDepth))
              {
                context.Read();
                weeklyAutoScalingSchedule.Sunday = new Dictionary<String,String>();
                KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;
                  if (token == JsonToken.ArrayStart || token == JsonToken.ObjectStart)
                  {
                      continue;
                  }
                  if (token == JsonToken.ArrayEnd || token == JsonToken.ObjectEnd)
                  {
                      break;
                  }
                  KeyValuePair<string, string> kvp = unmarshaller.Unmarshall(context);
                    weeklyAutoScalingSchedule.Sunday.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return weeklyAutoScalingSchedule;
                }
            }
          

            return weeklyAutoScalingSchedule;
        }

        private static WeeklyAutoScalingScheduleUnmarshaller instance;
        public static WeeklyAutoScalingScheduleUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WeeklyAutoScalingScheduleUnmarshaller();
            return instance;
        }
    }
}
  
