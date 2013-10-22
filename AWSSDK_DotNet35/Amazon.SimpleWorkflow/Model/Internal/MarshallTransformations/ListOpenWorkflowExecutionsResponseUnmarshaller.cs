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
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for ListOpenWorkflowExecutions operation
      /// </summary>
      internal class ListOpenWorkflowExecutionsResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          ListOpenWorkflowExecutionsResponse response = new ListOpenWorkflowExecutionsResponse();
          
          context.Read();
          UnmarshallResult(context,response);          
          
          return response;
        }        
        
        
        private static void UnmarshallResult(JsonUnmarshallerContext context,ListOpenWorkflowExecutionsResponse response)
        {                   
          response.WorkflowExecutionInfos = WorkflowExecutionInfosUnmarshaller.GetInstance().Unmarshall(context);
          return;
        }
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);                    
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("OperationNotPermittedException"))
          {
            return new OperationNotPermittedException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("UnknownResourceException"))
          {
            return new UnknownResourceException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          return new AmazonSimpleWorkflowException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static ListOpenWorkflowExecutionsResponseUnmarshaller instance;
        public static ListOpenWorkflowExecutionsResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new ListOpenWorkflowExecutionsResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  
