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
      /// KeysAndAttributesUnmarshaller
      /// </summary>
      internal class KeysAndAttributesUnmarshaller : IUnmarshaller<KeysAndAttributes, XmlUnmarshallerContext>, IUnmarshaller<KeysAndAttributes, JsonUnmarshallerContext>
      {
        KeysAndAttributes IUnmarshaller<KeysAndAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public KeysAndAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            KeysAndAttributes keysAndAttributes = new KeysAndAttributes();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Keys", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<Dictionary<string,AttributeValue>,DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>>(
                    new DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>(StringUnmarshaller.GetInstance(),AttributeValueUnmarshaller.GetInstance()));                  
                keysAndAttributes.Keys = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("AttributesToGet", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                keysAndAttributes.AttributesToGet = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("ConsistentRead", targetDepth))
              {
                keysAndAttributes.ConsistentRead = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return keysAndAttributes;
        }

        private static KeysAndAttributesUnmarshaller instance;
        public static KeysAndAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new KeysAndAttributesUnmarshaller();
            return instance;
        }
    }
}
  
