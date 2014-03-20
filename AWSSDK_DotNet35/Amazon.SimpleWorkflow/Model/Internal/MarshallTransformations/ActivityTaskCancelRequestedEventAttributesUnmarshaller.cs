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
      /// ActivityTaskCancelRequestedEventAttributesUnmarshaller
      /// </summary>
      internal class ActivityTaskCancelRequestedEventAttributesUnmarshaller : IUnmarshaller<ActivityTaskCancelRequestedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<ActivityTaskCancelRequestedEventAttributes, JsonUnmarshallerContext>
      {
        ActivityTaskCancelRequestedEventAttributes IUnmarshaller<ActivityTaskCancelRequestedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ActivityTaskCancelRequestedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            ActivityTaskCancelRequestedEventAttributes activityTaskCancelRequestedEventAttributes = new ActivityTaskCancelRequestedEventAttributes();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                activityTaskCancelRequestedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityId", targetDepth))
              {
                activityTaskCancelRequestedEventAttributes.ActivityId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return activityTaskCancelRequestedEventAttributes;
        }

        private static ActivityTaskCancelRequestedEventAttributesUnmarshaller instance;
        public static ActivityTaskCancelRequestedEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ActivityTaskCancelRequestedEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
