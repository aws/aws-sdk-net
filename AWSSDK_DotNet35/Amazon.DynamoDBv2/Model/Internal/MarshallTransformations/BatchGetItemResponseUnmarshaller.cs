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
    using Amazon.DynamoDBv2.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for BatchGetItem operation
      /// </summary>
      internal class BatchGetItemResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          BatchGetItemResponse response = new BatchGetItemResponse();          
          
          context.Read();
          
          UnmarshallResult(context,response);
          return response;
        }
        
        private static void UnmarshallResult(JsonUnmarshallerContext context,BatchGetItemResponse response)
        {
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("Responses", targetDepth))
              {
                context.Read();
                response.Responses = new Dictionary<String,List<Dictionary<string,AttributeValue>>>();
                KeyValueUnmarshaller<string, List<Dictionary<string,AttributeValue>>, StringUnmarshaller, ListUnmarshaller<Dictionary<string,AttributeValue>, DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>>> unmarshaller = new KeyValueUnmarshaller<string, List<Dictionary<string,AttributeValue>>, StringUnmarshaller, ListUnmarshaller<Dictionary<string,AttributeValue>, DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>>>(StringUnmarshaller.GetInstance(), new ListUnmarshaller<Dictionary<string,AttributeValue>, DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>>(new DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>(StringUnmarshaller.GetInstance(),AttributeValueUnmarshaller.GetInstance())));
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;
                  if (token == JsonToken.ArrayStart || token == JsonToken.ObjectStart)
                  {
                      continue;
                  }
                  if (token == JsonToken.ArrayEnd || token == JsonToken.ObjectEnd)
                  {
                      break;
                  }
                  KeyValuePair<string, List<Dictionary<string,AttributeValue>>> kvp = unmarshaller.Unmarshall(context);
                    response.Responses.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
              if (context.TestExpression("UnprocessedKeys", targetDepth))
              {
                context.Read();
                response.UnprocessedKeys = new Dictionary<String,KeysAndAttributes>();
                KeyValueUnmarshaller<string, KeysAndAttributes, StringUnmarshaller, KeysAndAttributesUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, KeysAndAttributes, StringUnmarshaller, KeysAndAttributesUnmarshaller>(StringUnmarshaller.GetInstance(), KeysAndAttributesUnmarshaller.GetInstance());
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;
                  if (token == JsonToken.ArrayStart || token == JsonToken.ObjectStart)
                  {
                      continue;
                  }
                  if (token == JsonToken.ArrayEnd || token == JsonToken.ObjectEnd)
                  {
                      break;
                  }
                  KeyValuePair<string, KeysAndAttributes> kvp = unmarshaller.Unmarshall(context);
                    response.UnprocessedKeys.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
              if (context.TestExpression("ConsumedCapacity", targetDepth))
              {
                context.Read();
                response.ConsumedCapacity = new List<ConsumedCapacity>();
                        ConsumedCapacityUnmarshaller unmarshaller = ConsumedCapacityUnmarshaller.GetInstance();
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
                   response.ConsumedCapacity.Add(unmarshaller.Unmarshall(context));
                }
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
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
          {
            return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("ProvisionedThroughputExceededException"))
          {
            return new ProvisionedThroughputExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException"))
          {
            return new InternalServerErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          return new AmazonDynamoDBException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static BatchGetItemResponseUnmarshaller instance;
        public static BatchGetItemResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new BatchGetItemResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  
