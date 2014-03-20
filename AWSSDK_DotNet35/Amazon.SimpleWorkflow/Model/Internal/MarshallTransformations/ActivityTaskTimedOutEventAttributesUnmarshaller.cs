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
      /// ActivityTaskTimedOutEventAttributesUnmarshaller
      /// </summary>
      internal class ActivityTaskTimedOutEventAttributesUnmarshaller : IUnmarshaller<ActivityTaskTimedOutEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<ActivityTaskTimedOutEventAttributes, JsonUnmarshallerContext>
      {
        ActivityTaskTimedOutEventAttributes IUnmarshaller<ActivityTaskTimedOutEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ActivityTaskTimedOutEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            ActivityTaskTimedOutEventAttributes activityTaskTimedOutEventAttributes = new ActivityTaskTimedOutEventAttributes();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("timeoutType", targetDepth))
              {
                activityTaskTimedOutEventAttributes.TimeoutType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("scheduledEventId", targetDepth))
              {
                activityTaskTimedOutEventAttributes.ScheduledEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startedEventId", targetDepth))
              {
                activityTaskTimedOutEventAttributes.StartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("details", targetDepth))
              {
                activityTaskTimedOutEventAttributes.Details = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return activityTaskTimedOutEventAttributes;
        }

        private static ActivityTaskTimedOutEventAttributesUnmarshaller instance;
        public static ActivityTaskTimedOutEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ActivityTaskTimedOutEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
