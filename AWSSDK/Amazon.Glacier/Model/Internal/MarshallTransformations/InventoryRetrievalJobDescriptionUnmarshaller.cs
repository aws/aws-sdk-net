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
    using Amazon.Glacier.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Glacier.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// InventoryRetrievalJobDescriptionUnmarshaller
      /// </summary>
      internal class InventoryRetrievalJobDescriptionUnmarshaller : IUnmarshaller<InventoryRetrievalJobDescription, XmlUnmarshallerContext>, IUnmarshaller<InventoryRetrievalJobDescription, JsonUnmarshallerContext>
      {
        InventoryRetrievalJobDescription IUnmarshaller<InventoryRetrievalJobDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public InventoryRetrievalJobDescription Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            InventoryRetrievalJobDescription inventoryRetrievalJobDescription = new InventoryRetrievalJobDescription();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Format", targetDepth))
              {
                inventoryRetrievalJobDescription.Format = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StartDate", targetDepth))
              {
                inventoryRetrievalJobDescription.StartDate = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("EndDate", targetDepth))
              {
                inventoryRetrievalJobDescription.EndDate = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Limit", targetDepth))
              {
                inventoryRetrievalJobDescription.Limit = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Marker", targetDepth))
              {
                inventoryRetrievalJobDescription.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return inventoryRetrievalJobDescription;
                }
            }
          

            return inventoryRetrievalJobDescription;
        }

        private static InventoryRetrievalJobDescriptionUnmarshaller instance;
        public static InventoryRetrievalJobDescriptionUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new InventoryRetrievalJobDescriptionUnmarshaller();
            return instance;
        }
    }
}
  
