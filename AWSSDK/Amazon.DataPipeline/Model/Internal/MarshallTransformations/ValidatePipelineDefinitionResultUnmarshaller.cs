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
      /// ValidatePipelineDefinitionResultUnmarshaller
      /// </summary>
      internal class ValidatePipelineDefinitionResultUnmarshaller : IUnmarshaller<ValidatePipelineDefinitionResult, XmlUnmarshallerContext>, IUnmarshaller<ValidatePipelineDefinitionResult, JsonUnmarshallerContext>
      {
        ValidatePipelineDefinitionResult IUnmarshaller<ValidatePipelineDefinitionResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ValidatePipelineDefinitionResult Unmarshall(JsonUnmarshallerContext context)
        {
            ValidatePipelineDefinitionResult validatePipelineDefinitionResult = new ValidatePipelineDefinitionResult();
          validatePipelineDefinitionResult.ValidationErrors = null;
                        
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
                validatePipelineDefinitionResult.ValidationErrors = new List<ValidationError>();
                        ValidationErrorUnmarshaller unmarshaller = ValidationErrorUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     validatePipelineDefinitionResult.ValidationErrors.Add(unmarshaller.Unmarshall(context));
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
                validatePipelineDefinitionResult.Errored = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return validatePipelineDefinitionResult;
                }
            }
          

            return validatePipelineDefinitionResult;
        }

        private static ValidatePipelineDefinitionResultUnmarshaller instance;
        public static ValidatePipelineDefinitionResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ValidatePipelineDefinitionResultUnmarshaller();
            return instance;
        }
    }
}
  
