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
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// StepTimelineUnmarshaller
      /// </summary>
      internal class StepTimelineUnmarshaller : IUnmarshaller<StepTimeline, XmlUnmarshallerContext>, IUnmarshaller<StepTimeline, JsonUnmarshallerContext>
      {
        StepTimeline IUnmarshaller<StepTimeline, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public StepTimeline Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            StepTimeline stepTimeline = new StepTimeline();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("CreationDateTime", targetDepth))
              {
                context.Read();
                stepTimeline.CreationDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StartDateTime", targetDepth))
              {
                context.Read();
                stepTimeline.StartDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("EndDateTime", targetDepth))
              {
                context.Read();
                stepTimeline.EndDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return stepTimeline;
                }
            }
          

            return stepTimeline;
        }

        private static StepTimelineUnmarshaller instance;
        public static StepTimelineUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new StepTimelineUnmarshaller();
            return instance;
        }
    }
}
  
