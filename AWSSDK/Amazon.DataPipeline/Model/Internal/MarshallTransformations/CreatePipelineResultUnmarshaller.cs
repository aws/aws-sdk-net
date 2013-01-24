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
      /// CreatePipelineResultUnmarshaller
      /// </summary>
      internal class CreatePipelineResultUnmarshaller : IUnmarshaller<CreatePipelineResult, XmlUnmarshallerContext>, IUnmarshaller<CreatePipelineResult, JsonUnmarshallerContext>
      {
        CreatePipelineResult IUnmarshaller<CreatePipelineResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public CreatePipelineResult Unmarshall(JsonUnmarshallerContext context)
        {
            CreatePipelineResult createPipelineResult = new CreatePipelineResult();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("PipelineId", targetDepth))
              {
                createPipelineResult.PipelineId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return createPipelineResult;
                }
            }
          

            return createPipelineResult;
        }

        private static CreatePipelineResultUnmarshaller instance;
        public static CreatePipelineResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CreatePipelineResultUnmarshaller();
            return instance;
        }
    }
}
  
