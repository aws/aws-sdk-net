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
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            TableDescription tableDescription = new TableDescription();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("AttributeDefinitions", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<AttributeDefinition,AttributeDefinitionUnmarshaller>(
                    AttributeDefinitionUnmarshaller.GetInstance());                  
                tableDescription.AttributeDefinitions = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("TableName", targetDepth))
              {
                tableDescription.TableName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("KeySchema", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<KeySchemaElement,KeySchemaElementUnmarshaller>(
                    KeySchemaElementUnmarshaller.GetInstance());                  
                tableDescription.KeySchema = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("TableStatus", targetDepth))
              {
                tableDescription.TableStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreationDateTime", targetDepth))
              {
                tableDescription.CreationDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ProvisionedThroughput", targetDepth))
              {
                tableDescription.ProvisionedThroughput = ProvisionedThroughputDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TableSizeBytes", targetDepth))
              {
                tableDescription.TableSizeBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ItemCount", targetDepth))
              {
                tableDescription.ItemCount = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LocalSecondaryIndexes", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<LocalSecondaryIndexDescription,LocalSecondaryIndexDescriptionUnmarshaller>(
                    LocalSecondaryIndexDescriptionUnmarshaller.GetInstance());                  
                tableDescription.LocalSecondaryIndexes = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("GlobalSecondaryIndexes", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<GlobalSecondaryIndexDescription,GlobalSecondaryIndexDescriptionUnmarshaller>(
                    GlobalSecondaryIndexDescriptionUnmarshaller.GetInstance());                  
                tableDescription.GlobalSecondaryIndexes = unmarshaller.Unmarshall(context);
                
                continue;
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
  
