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
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            WeeklyAutoScalingSchedule weeklyAutoScalingSchedule = new WeeklyAutoScalingSchedule();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Monday", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,String,StringUnmarshaller,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance(),StringUnmarshaller.GetInstance());               
                weeklyAutoScalingSchedule.Monday = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Tuesday", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,String,StringUnmarshaller,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance(),StringUnmarshaller.GetInstance());               
                weeklyAutoScalingSchedule.Tuesday = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Wednesday", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,String,StringUnmarshaller,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance(),StringUnmarshaller.GetInstance());               
                weeklyAutoScalingSchedule.Wednesday = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Thursday", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,String,StringUnmarshaller,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance(),StringUnmarshaller.GetInstance());               
                weeklyAutoScalingSchedule.Thursday = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Friday", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,String,StringUnmarshaller,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance(),StringUnmarshaller.GetInstance());               
                weeklyAutoScalingSchedule.Friday = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Saturday", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,String,StringUnmarshaller,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance(),StringUnmarshaller.GetInstance());               
                weeklyAutoScalingSchedule.Saturday = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Sunday", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,String,StringUnmarshaller,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance(),StringUnmarshaller.GetInstance());               
                weeklyAutoScalingSchedule.Sunday = unmarshaller.Unmarshall(context);
                
                continue;
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
  
