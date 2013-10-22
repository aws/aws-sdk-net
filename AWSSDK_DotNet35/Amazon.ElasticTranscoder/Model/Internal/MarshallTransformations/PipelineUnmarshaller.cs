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
      /// PipelineUnmarshaller
      /// </summary>
      internal class PipelineUnmarshaller : IUnmarshaller<Pipeline, XmlUnmarshallerContext>, IUnmarshaller<Pipeline, JsonUnmarshallerContext>
      {
        Pipeline IUnmarshaller<Pipeline, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Pipeline Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            Pipeline pipeline = new Pipeline();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("Id", targetDepth))
              {
                context.Read();
                pipeline.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Arn", targetDepth))
              {
                context.Read();
                pipeline.Arn = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                context.Read();
                pipeline.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                context.Read();
                pipeline.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InputBucket", targetDepth))
              {
                context.Read();
                pipeline.InputBucket = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("OutputBucket", targetDepth))
              {
                context.Read();
                pipeline.OutputBucket = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Role", targetDepth))
              {
                context.Read();
                pipeline.Role = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Notifications", targetDepth))
              {
                context.Read();
                pipeline.Notifications = NotificationsUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ContentConfig", targetDepth))
              {
                context.Read();
                pipeline.ContentConfig = PipelineOutputConfigUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ThumbnailConfig", targetDepth))
              {
                context.Read();
                pipeline.ThumbnailConfig = PipelineOutputConfigUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return pipeline;
                }
            }
          

            return pipeline;
        }

        private static PipelineUnmarshaller instance;
        public static PipelineUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PipelineUnmarshaller();
            return instance;
        }
    }
}
  
