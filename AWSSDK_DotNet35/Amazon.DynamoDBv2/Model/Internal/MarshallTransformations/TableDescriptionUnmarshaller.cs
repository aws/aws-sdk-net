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
      /// TableDescriptionUnmarshaller
      /// </summary>
      internal class TableDescriptionUnmarshaller : IUnmarshaller<TableDescription, XmlUnmarshallerContext>, IUnmarshaller<TableDescription, JsonUnmarshallerContext>
      {
        TableDescription IUnmarshaller<TableDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public TableDescription Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            TableDescription tableDescription = new TableDescription();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("AttributeDefinitions", targetDepth))
              {
                context.Read();
                tableDescription.AttributeDefinitions = new List<AttributeDefinition>();
                        AttributeDefinitionUnmarshaller unmarshaller = AttributeDefinitionUnmarshaller.GetInstance();
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
                   tableDescription.AttributeDefinitions.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("TableName", targetDepth))
              {
                context.Read();
                tableDescription.TableName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("KeySchema", targetDepth))
              {
                context.Read();
                tableDescription.KeySchema = new List<KeySchemaElement>();
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
                   tableDescription.KeySchema.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("TableStatus", targetDepth))
              {
                context.Read();
                tableDescription.TableStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreationDateTime", targetDepth))
              {
                context.Read();
                tableDescription.CreationDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ProvisionedThroughput", targetDepth))
              {
                context.Read();
                tableDescription.ProvisionedThroughput = ProvisionedThroughputDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TableSizeBytes", targetDepth))
              {
                context.Read();
                tableDescription.TableSizeBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ItemCount", targetDepth))
              {
                context.Read();
                tableDescription.ItemCount = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LocalSecondaryIndexes", targetDepth))
              {
                context.Read();
                tableDescription.LocalSecondaryIndexes = new List<LocalSecondaryIndexDescription>();
                        LocalSecondaryIndexDescriptionUnmarshaller unmarshaller = LocalSecondaryIndexDescriptionUnmarshaller.GetInstance();
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
                   tableDescription.LocalSecondaryIndexes.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("GlobalSecondaryIndexes", targetDepth))
              {
                context.Read();
                tableDescription.GlobalSecondaryIndexes = new List<GlobalSecondaryIndexDescription>();
                        GlobalSecondaryIndexDescriptionUnmarshaller unmarshaller = GlobalSecondaryIndexDescriptionUnmarshaller.GetInstance();
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
                   tableDescription.GlobalSecondaryIndexes.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return tableDescription;
                }
            }
          

            return tableDescription;
        }

        private static TableDescriptionUnmarshaller instance;
        public static TableDescriptionUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new TableDescriptionUnmarshaller();
            return instance;
        }
    }
}
  
