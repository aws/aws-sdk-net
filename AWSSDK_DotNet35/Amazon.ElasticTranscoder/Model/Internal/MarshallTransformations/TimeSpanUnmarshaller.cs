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
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// TimeSpanUnmarshaller
      /// </summary>
      internal class TimeSpanUnmarshaller : IUnmarshaller<TimeSpan, XmlUnmarshallerContext>, IUnmarshaller<TimeSpan, JsonUnmarshallerContext>
      {
        TimeSpan IUnmarshaller<TimeSpan, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public TimeSpan Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            TimeSpan timeSpan = new TimeSpan();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("StartTime", targetDepth))
              {
                context.Read();
                timeSpan.StartTime = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Duration", targetDepth))
              {
                context.Read();
                timeSpan.Duration = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return timeSpan;
                }
            }
          

            return timeSpan;
        }

        private static TimeSpanUnmarshaller instance;
        public static TimeSpanUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new TimeSpanUnmarshaller();
            return instance;
        }
    }
}
  
