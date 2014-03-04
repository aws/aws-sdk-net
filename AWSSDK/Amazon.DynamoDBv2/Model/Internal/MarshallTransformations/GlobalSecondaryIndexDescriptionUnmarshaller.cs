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
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            GlobalSecondaryIndexDescription globalSecondaryIndexDescription = new GlobalSecondaryIndexDescription();
          globalSecondaryIndexDescription.KeySchema = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("IndexName", targetDepth))
              {
                globalSecondaryIndexDescription.IndexName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("KeySchema", targetDepth))
              {
                globalSecondaryIndexDescription.KeySchema = new List<KeySchemaElement>();
                        KeySchemaElementUnmarshaller unmarshaller = KeySchemaElementUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     globalSecondaryIndexDescription.KeySchema.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
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
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return globalSecondaryIndexDescription;
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
  
