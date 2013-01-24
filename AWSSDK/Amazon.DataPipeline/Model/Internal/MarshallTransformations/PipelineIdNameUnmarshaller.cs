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
    using Amazon.DataPipeline.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// PipelineIdNameUnmarshaller
      /// </summary>
      internal class PipelineIdNameUnmarshaller : IUnmarshaller<PipelineIdName, XmlUnmarshallerContext>, IUnmarshaller<PipelineIdName, JsonUnmarshallerContext>
      {
        PipelineIdName IUnmarshaller<PipelineIdName, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public PipelineIdName Unmarshall(JsonUnmarshallerContext context)
        {
            PipelineIdName pipelineIdName = new PipelineIdName();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Id", targetDepth))
              {
                pipelineIdName.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                pipelineIdName.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return pipelineIdName;
                }
            }
          

            return pipelineIdName;
        }

        private static PipelineIdNameUnmarshaller instance;
        public static PipelineIdNameUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PipelineIdNameUnmarshaller();
            return instance;
        }
    }
}
  
