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
      /// ActivityTaskCanceledEventAttributesUnmarshaller
      /// </summary>
      internal class ActivityTaskCanceledEventAttributesUnmarshaller : IUnmarshaller<ActivityTaskCanceledEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<ActivityTaskCanceledEventAttributes, JsonUnmarshallerContext>
      {
        ActivityTaskCanceledEventAttributes IUnmarshaller<ActivityTaskCanceledEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ActivityTaskCanceledEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            ActivityTaskCanceledEventAttributes activityTaskCanceledEventAttributes = new ActivityTaskCanceledEventAttributes();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("details", targetDepth))
              {
                activityTaskCanceledEventAttributes.Details = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("scheduledEventId", targetDepth))
              {
                activityTaskCanceledEventAttributes.ScheduledEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startedEventId", targetDepth))
              {
                activityTaskCanceledEventAttributes.StartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("latestCancelRequestedEventId", targetDepth))
              {
                activityTaskCanceledEventAttributes.LatestCancelRequestedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return activityTaskCanceledEventAttributes;
        }

        private static ActivityTaskCanceledEventAttributesUnmarshaller instance;
        public static ActivityTaskCanceledEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ActivityTaskCanceledEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
