/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            ConsumedCapacity consumedCapacity = new ConsumedCapacity();
          consumedCapacity.LocalSecondaryIndexes = null;
                        consumedCapacity.GlobalSecondaryIndexes = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("TableName", targetDepth))
              {
                consumedCapacity.TableName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CapacityUnits", targetDepth))
              {
                consumedCapacity.CapacityUnits = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Table", targetDepth))
              {
                consumedCapacity.Table = CapacityUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LocalSecondaryIndexes", targetDepth))
              {
                consumedCapacity.LocalSecondaryIndexes = new Dictionary<String,Capacity>();
                if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                {
                  continue;
                }              
                KeyValueUnmarshaller<string, Capacity, StringUnmarshaller, CapacityUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, Capacity, StringUnmarshaller, CapacityUnmarshaller>(StringUnmarshaller.GetInstance(), CapacityUnmarshaller.GetInstance());
                while (context.Read())
                {
                  if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                      ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                  {
                    KeyValuePair<string, Capacity> kvp = unmarshaller.Unmarshall(context);
                    consumedCapacity.LocalSecondaryIndexes.Add(kvp.Key, kvp.Value);
                  }
                  else if (context.IsEndElement)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("GlobalSecondaryIndexes", targetDepth))
              {
                consumedCapacity.GlobalSecondaryIndexes = new Dictionary<String,Capacity>();
                if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                {
                  continue;
                }              
                KeyValueUnmarshaller<string, Capacity, StringUnmarshaller, CapacityUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, Capacity, StringUnmarshaller, CapacityUnmarshaller>(StringUnmarshaller.GetInstance(), CapacityUnmarshaller.GetInstance());
                while (context.Read())
                {
                  if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                      ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                  {
                    KeyValuePair<string, Capacity> kvp = unmarshaller.Unmarshall(context);
                    consumedCapacity.GlobalSecondaryIndexes.Add(kvp.Key, kvp.Value);
                  }
                  else if (context.IsEndElement)
                  {
                    break;
                  }
                }
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
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
  
