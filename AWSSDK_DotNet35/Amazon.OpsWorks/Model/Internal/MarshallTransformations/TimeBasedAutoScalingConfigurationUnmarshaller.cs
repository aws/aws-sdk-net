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
      /// TimeBasedAutoScalingConfigurationUnmarshaller
      /// </summary>
      internal class TimeBasedAutoScalingConfigurationUnmarshaller : IUnmarshaller<TimeBasedAutoScalingConfiguration, XmlUnmarshallerContext>, IUnmarshaller<TimeBasedAutoScalingConfiguration, JsonUnmarshallerContext>
      {
        TimeBasedAutoScalingConfiguration IUnmarshaller<TimeBasedAutoScalingConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public TimeBasedAutoScalingConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            TimeBasedAutoScalingConfiguration timeBasedAutoScalingConfiguration = new TimeBasedAutoScalingConfiguration();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("InstanceId", targetDepth))
              {
                context.Read();
                timeBasedAutoScalingConfiguration.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AutoScalingSchedule", targetDepth))
              {
                context.Read();
                timeBasedAutoScalingConfiguration.AutoScalingSchedule = WeeklyAutoScalingScheduleUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return timeBasedAutoScalingConfiguration;
                }
            }
          

            return timeBasedAutoScalingConfiguration;
        }

        private static TimeBasedAutoScalingConfigurationUnmarshaller instance;
        public static TimeBasedAutoScalingConfigurationUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new TimeBasedAutoScalingConfigurationUnmarshaller();
            return instance;
        }
    }
}
  
