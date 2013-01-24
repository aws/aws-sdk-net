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
      /// PutPipelineDefinitionResultUnmarshaller
      /// </summary>
      internal class PutPipelineDefinitionResultUnmarshaller : IUnmarshaller<PutPipelineDefinitionResult, XmlUnmarshallerContext>, IUnmarshaller<PutPipelineDefinitionResult, JsonUnmarshallerContext>
      {
        PutPipelineDefinitionResult IUnmarshaller<PutPipelineDefinitionResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public PutPipelineDefinitionResult Unmarshall(JsonUnmarshallerContext context)
        {
            PutPipelineDefinitionResult putPipelineDefinitionResult = new PutPipelineDefinitionResult();
          putPipelineDefinitionResult.ValidationErrors = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("ValidationErrors", targetDepth))
              {
                putPipelineDefinitionResult.ValidationErrors = new List<ValidationError>();
                        ValidationErrorUnmarshaller unmarshaller = ValidationErrorUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     putPipelineDefinitionResult.ValidationErrors.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("Errored", targetDepth))
              {
                putPipelineDefinitionResult.Errored = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return putPipelineDefinitionResult;
                }
            }
          

            return putPipelineDefinitionResult;
        }

        private static PutPipelineDefinitionResultUnmarshaller instance;
        public static PutPipelineDefinitionResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PutPipelineDefinitionResultUnmarshaller();
            return instance;
        }
    }
}
  
