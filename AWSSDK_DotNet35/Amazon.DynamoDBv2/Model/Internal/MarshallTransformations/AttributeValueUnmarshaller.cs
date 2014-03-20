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
      /// AttributeValueUnmarshaller
      /// </summary>
      internal class AttributeValueUnmarshaller : IUnmarshaller<AttributeValue, XmlUnmarshallerContext>, IUnmarshaller<AttributeValue, JsonUnmarshallerContext>
      {
        AttributeValue IUnmarshaller<AttributeValue, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public AttributeValue Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            AttributeValue attributeValue = new AttributeValue();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("S", targetDepth))
              {
                attributeValue.S = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("N", targetDepth))
              {
                attributeValue.N = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("B", targetDepth))
              {
                attributeValue.B = MemoryStreamUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SS", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                attributeValue.SS = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("NS", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                attributeValue.NS = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("BS", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<MemoryStream,MemoryStreamUnmarshaller>(
                    MemoryStreamUnmarshaller.GetInstance());                  
                attributeValue.BS = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
            }
          
            return attributeValue;
        }

        private static AttributeValueUnmarshaller instance;
        public static AttributeValueUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new AttributeValueUnmarshaller();
            return instance;
        }
    }
}
  
