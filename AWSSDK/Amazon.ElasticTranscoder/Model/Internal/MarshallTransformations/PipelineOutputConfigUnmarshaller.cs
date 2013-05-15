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
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// PipelineOutputConfigUnmarshaller
      /// </summary>
      internal class PipelineOutputConfigUnmarshaller : IUnmarshaller<PipelineOutputConfig, XmlUnmarshallerContext>, IUnmarshaller<PipelineOutputConfig, JsonUnmarshallerContext>
      {
        PipelineOutputConfig IUnmarshaller<PipelineOutputConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public PipelineOutputConfig Unmarshall(JsonUnmarshallerContext context)
        {
            PipelineOutputConfig pipelineOutputConfig = new PipelineOutputConfig();
          pipelineOutputConfig.Permissions = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Bucket", targetDepth))
              {
                pipelineOutputConfig.Bucket = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StorageClass", targetDepth))
              {
                pipelineOutputConfig.StorageClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Permissions", targetDepth))
              {
                pipelineOutputConfig.Permissions = new List<Permission>();
                        PermissionUnmarshaller unmarshaller = PermissionUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     pipelineOutputConfig.Permissions.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return pipelineOutputConfig;
                }
            }
          

            return pipelineOutputConfig;
        }

        private static PipelineOutputConfigUnmarshaller instance;
        public static PipelineOutputConfigUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PipelineOutputConfigUnmarshaller();
            return instance;
        }
    }
}
  
