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
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ActivityTypeConfigurationUnmarshaller
      /// </summary>
      internal class ActivityTypeConfigurationUnmarshaller : IUnmarshaller<ActivityTypeConfiguration, XmlUnmarshallerContext>, IUnmarshaller<ActivityTypeConfiguration, JsonUnmarshallerContext>
      {
        ActivityTypeConfiguration IUnmarshaller<ActivityTypeConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ActivityTypeConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            ActivityTypeConfiguration activityTypeConfiguration = new ActivityTypeConfiguration();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("defaultTaskStartToCloseTimeout", targetDepth))
              {
                activityTypeConfiguration.DefaultTaskStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("defaultTaskHeartbeatTimeout", targetDepth))
              {
                activityTypeConfiguration.DefaultTaskHeartbeatTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("defaultTaskList", targetDepth))
              {
                activityTypeConfiguration.DefaultTaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("defaultTaskScheduleToStartTimeout", targetDepth))
              {
                activityTypeConfiguration.DefaultTaskScheduleToStartTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("defaultTaskScheduleToCloseTimeout", targetDepth))
              {
                activityTypeConfiguration.DefaultTaskScheduleToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return activityTypeConfiguration;
        }

        private static ActivityTypeConfigurationUnmarshaller instance;
        public static ActivityTypeConfigurationUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ActivityTypeConfigurationUnmarshaller();
            return instance;
        }
    }
}
  
