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
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// JobInputUnmarshaller
      /// </summary>
      internal class JobInputUnmarshaller : IUnmarshaller<JobInput, XmlUnmarshallerContext>, IUnmarshaller<JobInput, JsonUnmarshallerContext>
      {
        JobInput IUnmarshaller<JobInput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public JobInput Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            JobInput jobInput = new JobInput();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Key", targetDepth))
              {
                jobInput.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("FrameRate", targetDepth))
              {
                jobInput.FrameRate = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Resolution", targetDepth))
              {
                jobInput.Resolution = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AspectRatio", targetDepth))
              {
                jobInput.AspectRatio = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Interlaced", targetDepth))
              {
                jobInput.Interlaced = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Container", targetDepth))
              {
                jobInput.Container = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return jobInput;
        }

        private static JobInputUnmarshaller instance;
        public static JobInputUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new JobInputUnmarshaller();
            return instance;
        }
    }
}
  
