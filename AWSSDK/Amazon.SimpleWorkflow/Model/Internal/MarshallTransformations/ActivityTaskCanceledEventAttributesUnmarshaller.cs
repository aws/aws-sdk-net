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
            ActivityTaskCanceledEventAttributes activityTaskCanceledEventAttributes = new ActivityTaskCanceledEventAttributes();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Details", targetDepth))
              {
                activityTaskCanceledEventAttributes.Details = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ScheduledEventId", targetDepth))
              {
                activityTaskCanceledEventAttributes.ScheduledEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StartedEventId", targetDepth))
              {
                activityTaskCanceledEventAttributes.StartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LatestCancelRequestedEventId", targetDepth))
              {
                activityTaskCanceledEventAttributes.LatestCancelRequestedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return activityTaskCanceledEventAttributes;
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
  
