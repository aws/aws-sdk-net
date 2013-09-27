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
      /// ItemCollectionMetricsUnmarshaller
      /// </summary>
      internal class ItemCollectionMetricsUnmarshaller : IUnmarshaller<ItemCollectionMetrics, XmlUnmarshallerContext>, IUnmarshaller<ItemCollectionMetrics, JsonUnmarshallerContext>
      {
        ItemCollectionMetrics IUnmarshaller<ItemCollectionMetrics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ItemCollectionMetrics Unmarshall(JsonUnmarshallerContext context)
        {
            ItemCollectionMetrics itemCollectionMetrics = new ItemCollectionMetrics();
          itemCollectionMetrics.ItemCollectionKey = null;
                        itemCollectionMetrics.SizeEstimateRangeGB = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("ItemCollectionKey", targetDepth))
              {
                itemCollectionMetrics.ItemCollectionKey = new Dictionary<String,AttributeValue>();
                KeyValueUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>(StringUnmarshaller.GetInstance(), AttributeValueUnmarshaller.GetInstance());
                while (context.Read())
                {
                  if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                      ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                  {
                    KeyValuePair<string, AttributeValue> kvp = unmarshaller.Unmarshall(context);
                    itemCollectionMetrics.ItemCollectionKey.Add(kvp.Key, kvp.Value);
                  }
                  else if (context.IsEndElement)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("SizeEstimateRangeGB", targetDepth))
              {
                itemCollectionMetrics.SizeEstimateRangeGB = new List<Double>();
                        DoubleUnmarshaller unmarshaller = DoubleUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     itemCollectionMetrics.SizeEstimateRangeGB.Add(unmarshaller.Unmarshall(context));
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
                    return itemCollectionMetrics;
                }
            }
          

            return itemCollectionMetrics;
        }

        private static ItemCollectionMetricsUnmarshaller instance;
        public static ItemCollectionMetricsUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ItemCollectionMetricsUnmarshaller();
            return instance;
        }
    }
}
  
