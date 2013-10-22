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
      /// LocalSecondaryIndexDescriptionUnmarshaller
      /// </summary>
      internal class LocalSecondaryIndexDescriptionUnmarshaller : IUnmarshaller<LocalSecondaryIndexDescription, XmlUnmarshallerContext>, IUnmarshaller<LocalSecondaryIndexDescription, JsonUnmarshallerContext>
      {
        LocalSecondaryIndexDescription IUnmarshaller<LocalSecondaryIndexDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public LocalSecondaryIndexDescription Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            LocalSecondaryIndexDescription localSecondaryIndexDescription = new LocalSecondaryIndexDescription();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("IndexName", targetDepth))
              {
                context.Read();
                localSecondaryIndexDescription.IndexName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("KeySchema", targetDepth))
              {
                context.Read();
                localSecondaryIndexDescription.KeySchema = new List<KeySchemaElement>();
                        KeySchemaElementUnmarshaller unmarshaller = KeySchemaElementUnmarshaller.GetInstance();
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
                   localSecondaryIndexDescription.KeySchema.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("Projection", targetDepth))
              {
                context.Read();
                localSecondaryIndexDescription.Projection = ProjectionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("IndexSizeBytes", targetDepth))
              {
                context.Read();
                localSecondaryIndexDescription.IndexSizeBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ItemCount", targetDepth))
              {
                context.Read();
                localSecondaryIndexDescription.ItemCount = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return localSecondaryIndexDescription;
                }
            }
          

            return localSecondaryIndexDescription;
        }

        private static LocalSecondaryIndexDescriptionUnmarshaller instance;
        public static LocalSecondaryIndexDescriptionUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new LocalSecondaryIndexDescriptionUnmarshaller();
            return instance;
        }
    }
}
  
