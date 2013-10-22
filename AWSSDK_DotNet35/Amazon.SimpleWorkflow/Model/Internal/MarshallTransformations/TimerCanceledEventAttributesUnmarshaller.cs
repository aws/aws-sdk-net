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
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// TimerCanceledEventAttributesUnmarshaller
      /// </summary>
      internal class TimerCanceledEventAttributesUnmarshaller : IUnmarshaller<TimerCanceledEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<TimerCanceledEventAttributes, JsonUnmarshallerContext>
      {
        TimerCanceledEventAttributes IUnmarshaller<TimerCanceledEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public TimerCanceledEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            TimerCanceledEventAttributes timerCanceledEventAttributes = new TimerCanceledEventAttributes();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("timerId", targetDepth))
              {
                context.Read();
                timerCanceledEventAttributes.TimerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startedEventId", targetDepth))
              {
                context.Read();
                timerCanceledEventAttributes.StartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                context.Read();
                timerCanceledEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return timerCanceledEventAttributes;
                }
            }
          

            return timerCanceledEventAttributes;
        }

        private static TimerCanceledEventAttributesUnmarshaller instance;
        public static TimerCanceledEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new TimerCanceledEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
