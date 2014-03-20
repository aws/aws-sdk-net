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
      /// GlobalSecondaryIndexDescriptionUnmarshaller
      /// </summary>
      internal class GlobalSecondaryIndexDescriptionUnmarshaller : IUnmarshaller<GlobalSecondaryIndexDescription, XmlUnmarshallerContext>, IUnmarshaller<GlobalSecondaryIndexDescription, JsonUnmarshallerContext>
      {
        GlobalSecondaryIndexDescription IUnmarshaller<GlobalSecondaryIndexDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public GlobalSecondaryIndexDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            GlobalSecondaryIndexDescription globalSecondaryIndexDescription = new GlobalSecondaryIndexDescription();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("IndexName", targetDepth))
              {
                globalSecondaryIndexDescription.IndexName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("KeySchema", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<KeySchemaElement,KeySchemaElementUnmarshaller>(
                    KeySchemaElementUnmarshaller.GetInstance());                  
                globalSecondaryIndexDescription.KeySchema = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Projection", targetDepth))
              {
                globalSecondaryIndexDescription.Projection = ProjectionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("IndexStatus", targetDepth))
              {
                globalSecondaryIndexDescription.IndexStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ProvisionedThroughput", targetDepth))
              {
                globalSecondaryIndexDescription.ProvisionedThroughput = ProvisionedThroughputDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("IndexSizeBytes", targetDepth))
              {
                globalSecondaryIndexDescription.IndexSizeBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ItemCount", targetDepth))
              {
                globalSecondaryIndexDescription.ItemCount = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return globalSecondaryIndexDescription;
        }

        private static GlobalSecondaryIndexDescriptionUnmarshaller instance;
        public static GlobalSecondaryIndexDescriptionUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new GlobalSecondaryIndexDescriptionUnmarshaller();
            return instance;
        }
    }
}
  
