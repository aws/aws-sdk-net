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
    using ThirdParty.Json.LitJson;
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
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            ItemCollectionMetrics itemCollectionMetrics = new ItemCollectionMetrics();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("ItemCollectionKey", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,AttributeValue,StringUnmarshaller,AttributeValueUnmarshaller>(
                    StringUnmarshaller.GetInstance(),AttributeValueUnmarshaller.GetInstance());               
                itemCollectionMetrics.ItemCollectionKey = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("SizeEstimateRangeGB", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<Double,DoubleUnmarshaller>(
                    DoubleUnmarshaller.GetInstance());                  
                itemCollectionMetrics.SizeEstimateRangeGB = unmarshaller.Unmarshall(context);
                
                continue;
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
  
