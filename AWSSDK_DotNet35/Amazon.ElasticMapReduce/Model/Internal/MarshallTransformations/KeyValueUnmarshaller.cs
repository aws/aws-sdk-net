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
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// KeyValueUnmarshaller
      /// </summary>
      internal class KeyValueUnmarshaller : IUnmarshaller<KeyValue, XmlUnmarshallerContext>, IUnmarshaller<KeyValue, JsonUnmarshallerContext>
      {
        KeyValue IUnmarshaller<KeyValue, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public KeyValue Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            KeyValue keyValue = new KeyValue();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Key", targetDepth))
              {
                keyValue.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Value", targetDepth))
              {
                keyValue.Value = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return keyValue;
        }

        private static KeyValueUnmarshaller instance;
        public static KeyValueUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new KeyValueUnmarshaller();
            return instance;
        }
    }
}
  
