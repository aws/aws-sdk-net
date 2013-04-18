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
            KeysAndAttributes keysAndAttributes = new KeysAndAttributes();
          keysAndAttributes.Keys = null;
                        keysAndAttributes.AttributesToGet = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Keys", targetDepth))
              {
                keysAndAttributes.Keys = new List<Dictionary<string,AttributeValue>>();
                        DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller> unmarshaller = new DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>(StringUnmarshaller.GetInstance(),AttributeValueUnmarshaller.GetInstance());
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     keysAndAttributes.Keys.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("AttributesToGet", targetDepth))
              {
                keysAndAttributes.AttributesToGet = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     keysAndAttributes.AttributesToGet.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("ConsistentRead", targetDepth))
              {
                keysAndAttributes.ConsistentRead = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return keysAndAttributes;
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
  
