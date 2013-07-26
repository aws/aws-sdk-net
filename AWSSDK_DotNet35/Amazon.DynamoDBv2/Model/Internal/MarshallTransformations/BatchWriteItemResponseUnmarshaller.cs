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
    using Amazon.DynamoDBv2.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for BatchWriteItem operation
      /// </summary>
      internal class BatchWriteItemResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          BatchWriteItemResponse response = new BatchWriteItemResponse();          
          
          context.Read();
          
          UnmarshallResult(context,response);
          return response;
        }
        
        private void UnmarshallResult(JsonUnmarshallerContext context,BatchWriteItemResponse response)
        {
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("UnprocessedItems", targetDepth))
              {
                response.UnprocessedItems = new Dictionary<String,List<WriteRequest>>();
                KeyValueUnmarshaller<string, List<WriteRequest>, StringUnmarshaller, ListUnmarshaller<WriteRequest, WriteRequestUnmarshaller>> unmarshaller = new KeyValueUnmarshaller<string, List<WriteRequest>, StringUnmarshaller, ListUnmarshaller<WriteRequest, WriteRequestUnmarshaller>>(StringUnmarshaller.GetInstance(), new ListUnmarshaller<WriteRequest, WriteRequestUnmarshaller>(WriteRequestUnmarshaller.GetInstance()));
                while (context.Read())
                {
                  if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                      ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                  {
                    KeyValuePair<string, List<WriteRequest>> kvp = unmarshaller.Unmarshall(context);
                    response.UnprocessedItems.Add(kvp.Key, kvp.Value);
                  }
                  else if (context.IsEndElement)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("ItemCollectionMetrics", targetDepth))
              {
                response.ItemCollectionMetrics = new Dictionary<String,List<ItemCollectionMetrics>>();
                KeyValueUnmarshaller<string, List<ItemCollectionMetrics>, StringUnmarshaller, ListUnmarshaller<ItemCollectionMetrics, ItemCollectionMetricsUnmarshaller>> unmarshaller = new KeyValueUnmarshaller<string, List<ItemCollectionMetrics>, StringUnmarshaller, ListUnmarshaller<ItemCollectionMetrics, ItemCollectionMetricsUnmarshaller>>(StringUnmarshaller.GetInstance(), new ListUnmarshaller<ItemCollectionMetrics, ItemCollectionMetricsUnmarshaller>(ItemCollectionMetricsUnmarshaller.GetInstance()));
                while (context.Read())
                {
                  if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                      ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                  {
                    KeyValuePair<string, List<ItemCollectionMetrics>> kvp = unmarshaller.Unmarshall(context);
                    response.ItemCollectionMetrics.Add(kvp.Key, kvp.Value);
                  }
                  else if (context.IsEndElement)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("ConsumedCapacity", targetDepth))
              {
                response.ConsumedCapacity = new List<ConsumedCapacity>();
                        ConsumedCapacityUnmarshaller unmarshaller = ConsumedCapacityUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     response.ConsumedCapacity.Add(unmarshaller.Unmarshall(context));
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
                    return;
                }
            }
                        
            return;
        }                        
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);                    
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("ItemCollectionSizeLimitExceededException"))
          {
            return new ItemCollectionSizeLimitExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
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

        private static BatchWriteItemResponseUnmarshaller instance;
        public static BatchWriteItemResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new BatchWriteItemResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  
