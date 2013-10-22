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
    using System.Net;
    using System.Collections.Generic;
    using ThirdParty.Json.LitJson;
    using Amazon.DataPipeline.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for ValidatePipelineDefinition operation
      /// </summary>
      internal class ValidatePipelineDefinitionResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          ValidatePipelineDefinitionResponse response = new ValidatePipelineDefinitionResponse();          
          
          context.Read();
          
          UnmarshallResult(context,response);
          return response;
        }
        
        private static void UnmarshallResult(JsonUnmarshallerContext context,ValidatePipelineDefinitionResponse response)
        {
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("validationErrors", targetDepth))
              {
                context.Read();
                response.ValidationErrors = new List<ValidationError>();
                        ValidationErrorUnmarshaller unmarshaller = ValidationErrorUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   response.ValidationErrors.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("validationWarnings", targetDepth))
              {
                context.Read();
                response.ValidationWarnings = new List<ValidationWarning>();
                        ValidationWarningUnmarshaller unmarshaller = ValidationWarningUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   response.ValidationWarnings.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("errored", targetDepth))
              {
                context.Read();
                response.Errored = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {                   
                    return;
                }
            }
                        
            return;
        }                        
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);                    
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("PipelineNotFoundException"))
          {
            return new PipelineNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServiceErrorException"))
          {
            return new InternalServiceErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
          {
            return new InvalidRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("PipelineDeletedException"))
          {
            return new PipelineDeletedException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          return new AmazonDataPipelineException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static ValidatePipelineDefinitionResponseUnmarshaller instance;
        public static ValidatePipelineDefinitionResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new ValidatePipelineDefinitionResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  
