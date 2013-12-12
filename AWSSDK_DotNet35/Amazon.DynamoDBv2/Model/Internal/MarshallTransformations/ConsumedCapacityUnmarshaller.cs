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
    using ThirdParty.Json.LitJson;
    using Amazon.DynamoDBv2.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ConsumedCapacityUnmarshaller
      /// </summary>
      internal class ConsumedCapacityUnmarshaller : IUnmarshaller<ConsumedCapacity, XmlUnmarshallerContext>, IUnmarshaller<ConsumedCapacity, JsonUnmarshallerContext>
      {
        ConsumedCapacity IUnmarshaller<ConsumedCapacity, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ConsumedCapacity Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            ConsumedCapacity consumedCapacity = new ConsumedCapacity();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("TableName", targetDepth))
              {
                context.Read();
                consumedCapacity.TableName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CapacityUnits", targetDepth))
              {
                context.Read();
                consumedCapacity.CapacityUnits = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Table", targetDepth))
              {
                context.Read();
                consumedCapacity.Table = CapacityUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LocalSecondaryIndexes", targetDepth))
              {
                context.Read();
                consumedCapacity.LocalSecondaryIndexes = new Dictionary<String,Capacity>();
                KeyValueUnmarshaller<string, Capacity, StringUnmarshaller, CapacityUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, Capacity, StringUnmarshaller, CapacityUnmarshaller>(StringUnmarshaller.GetInstance(), CapacityUnmarshaller.GetInstance());
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
                  KeyValuePair<string, Capacity> kvp = unmarshaller.Unmarshall(context);
                    consumedCapacity.LocalSecondaryIndexes.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
              if (context.TestExpression("GlobalSecondaryIndexes", targetDepth))
              {
                context.Read();
                consumedCapacity.GlobalSecondaryIndexes = new Dictionary<String,Capacity>();
                KeyValueUnmarshaller<string, Capacity, StringUnmarshaller, CapacityUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, Capacity, StringUnmarshaller, CapacityUnmarshaller>(StringUnmarshaller.GetInstance(), CapacityUnmarshaller.GetInstance());
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
                  KeyValuePair<string, Capacity> kvp = unmarshaller.Unmarshall(context);
                    consumedCapacity.GlobalSecondaryIndexes.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return consumedCapacity;
                }
            }
          

            return consumedCapacity;
        }

        private static ConsumedCapacityUnmarshaller instance;
        public static ConsumedCapacityUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ConsumedCapacityUnmarshaller();
            return instance;
        }
    }
}
  
