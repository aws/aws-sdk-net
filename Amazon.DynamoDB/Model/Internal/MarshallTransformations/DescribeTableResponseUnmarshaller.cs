/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using Amazon.DynamoDB.Model; 
    using Amazon.Runtime; 
    using Amazon.Runtime.Internal; 
    using Amazon.Runtime.Internal.Transform; 
    
    namespace Amazon.DynamoDB.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// Response Unmarshaller for DescribeTable operation 
      /// </summary> 
      internal class DescribeTableResponseUnmarshaller : IResponseUnmarshaller<DescribeTableResponse, JsonUnmarshallerContext> 
      { 
        public DescribeTableResponse Unmarshall(JsonUnmarshallerContext context) 
        { 
          DescribeTableResponse response = new DescribeTableResponse();
          
          context.Read();
          response.DescribeTableResult = DescribeTableResultUnmarshaller.GetInstance().Unmarshall(context); 
           
          return response; 
        } 
         
        public AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode) 
        { 
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context); 
           
          if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException")) 
          { 
            return new InternalServerErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode); 
          } 
   
          if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException")) 
          { 
            return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode); 
          } 
   
          return new AmazonDynamoDBException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode); 
        } 
  
        private static DescribeTableResponseUnmarshaller instance; 
        public static DescribeTableResponseUnmarshaller GetInstance() 
        { 
          if (instance == null) 
          { 
            instance = new DescribeTableResponseUnmarshaller(); 
          } 
          return instance;
        } 
   
      } 
    } 
  
