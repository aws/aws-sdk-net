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
    using Amazon.DynamoDBv2.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// BatchWriteItemResultUnmarshaller
      /// </summary>
      internal class BatchWriteItemResultUnmarshaller : IUnmarshaller<BatchWriteItemResult, XmlUnmarshallerContext>, IUnmarshaller<BatchWriteItemResult, JsonUnmarshallerContext>
      {
        BatchWriteItemResult IUnmarshaller<BatchWriteItemResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public BatchWriteItemResult Unmarshall(JsonUnmarshallerContext context)
        {
            BatchWriteItemResult batchWriteItemResult = new BatchWriteItemResult();
          batchWriteItemResult.UnprocessedItems = null;
                        batchWriteItemResult.ItemCollectionMetrics = null;
                        batchWriteItemResult.ConsumedCapacity = null;
                        
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
                batchWriteItemResult.UnprocessedItems = new Dictionary<String,List<WriteRequest>>();
                KeyValueUnmarshaller<string, List<WriteRequest>, StringUnmarshaller, ListUnmarshaller<WriteRequest, WriteRequestUnmarshaller>> unmarshaller = new KeyValueUnmarshaller<string, List<WriteRequest>, StringUnmarshaller, ListUnmarshaller<WriteRequest, WriteRequestUnmarshaller>>(StringUnmarshaller.GetInstance(), new ListUnmarshaller<WriteRequest, WriteRequestUnmarshaller>(WriteRequestUnmarshaller.GetInstance()));
                while (context.Read())
                {
                  if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                      ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                  {
                    KeyValuePair<string, List<WriteRequest>> kvp = unmarshaller.Unmarshall(context);
                    batchWriteItemResult.UnprocessedItems.Add(kvp.Key, kvp.Value);
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
                batchWriteItemResult.ItemCollectionMetrics = new Dictionary<String,List<ItemCollectionMetrics>>();
                KeyValueUnmarshaller<string, List<ItemCollectionMetrics>, StringUnmarshaller, ListUnmarshaller<ItemCollectionMetrics, ItemCollectionMetricsUnmarshaller>> unmarshaller = new KeyValueUnmarshaller<string, List<ItemCollectionMetrics>, StringUnmarshaller, ListUnmarshaller<ItemCollectionMetrics, ItemCollectionMetricsUnmarshaller>>(StringUnmarshaller.GetInstance(), new ListUnmarshaller<ItemCollectionMetrics, ItemCollectionMetricsUnmarshaller>(ItemCollectionMetricsUnmarshaller.GetInstance()));
                while (context.Read())
                {
                  if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                      ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                  {
                    KeyValuePair<string, List<ItemCollectionMetrics>> kvp = unmarshaller.Unmarshall(context);
                    batchWriteItemResult.ItemCollectionMetrics.Add(kvp.Key, kvp.Value);
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
                batchWriteItemResult.ConsumedCapacity = new List<ConsumedCapacity>();
                        ConsumedCapacityUnmarshaller unmarshaller = ConsumedCapacityUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     batchWriteItemResult.ConsumedCapacity.Add(unmarshaller.Unmarshall(context));
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
                    return batchWriteItemResult;
                }
            }
          

            return batchWriteItemResult;
        }

        private static BatchWriteItemResultUnmarshaller instance;
        public static BatchWriteItemResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new BatchWriteItemResultUnmarshaller();
            return instance;
        }
    }
}
  
