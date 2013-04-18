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
      /// BatchGetItemResultUnmarshaller
      /// </summary>
      internal class BatchGetItemResultUnmarshaller : IUnmarshaller<BatchGetItemResult, XmlUnmarshallerContext>, IUnmarshaller<BatchGetItemResult, JsonUnmarshallerContext>
      {
        BatchGetItemResult IUnmarshaller<BatchGetItemResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public BatchGetItemResult Unmarshall(JsonUnmarshallerContext context)
        {
            BatchGetItemResult batchGetItemResult = new BatchGetItemResult();
          batchGetItemResult.Responses = null;
                        batchGetItemResult.UnprocessedKeys = null;
                        batchGetItemResult.ConsumedCapacity = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Responses", targetDepth))
              {
                batchGetItemResult.Responses = new Dictionary<String,List<Dictionary<string,AttributeValue>>>();
                KeyValueUnmarshaller<string, List<Dictionary<string,AttributeValue>>, StringUnmarshaller, ListUnmarshaller<Dictionary<string,AttributeValue>, DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>>> unmarshaller = new KeyValueUnmarshaller<string, List<Dictionary<string,AttributeValue>>, StringUnmarshaller, ListUnmarshaller<Dictionary<string,AttributeValue>, DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>>>(StringUnmarshaller.GetInstance(), new ListUnmarshaller<Dictionary<string,AttributeValue>, DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>>(new DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>(StringUnmarshaller.GetInstance(),AttributeValueUnmarshaller.GetInstance())));
                while (context.Read())
                {
                  if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                      ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                  {
                    KeyValuePair<string, List<Dictionary<string,AttributeValue>>> kvp = unmarshaller.Unmarshall(context);
                    batchGetItemResult.Responses.Add(kvp.Key, kvp.Value);
                  }
                  else if (context.IsEndElement)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("UnprocessedKeys", targetDepth))
              {
                batchGetItemResult.UnprocessedKeys = new Dictionary<String,KeysAndAttributes>();
                KeyValueUnmarshaller<string, KeysAndAttributes, StringUnmarshaller, KeysAndAttributesUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, KeysAndAttributes, StringUnmarshaller, KeysAndAttributesUnmarshaller>(StringUnmarshaller.GetInstance(), KeysAndAttributesUnmarshaller.GetInstance());
                while (context.Read())
                {
                  if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                      ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                  {
                    KeyValuePair<string, KeysAndAttributes> kvp = unmarshaller.Unmarshall(context);
                    batchGetItemResult.UnprocessedKeys.Add(kvp.Key, kvp.Value);
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
                batchGetItemResult.ConsumedCapacity = new List<ConsumedCapacity>();
                        ConsumedCapacityUnmarshaller unmarshaller = ConsumedCapacityUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     batchGetItemResult.ConsumedCapacity.Add(unmarshaller.Unmarshall(context));
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
                    return batchGetItemResult;
                }
            }
          

            return batchGetItemResult;
        }

        private static BatchGetItemResultUnmarshaller instance;
        public static BatchGetItemResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new BatchGetItemResultUnmarshaller();
            return instance;
        }
    }
}
  
