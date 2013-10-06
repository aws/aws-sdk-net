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
            KeyValue keyValue = new KeyValue();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
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
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return keyValue;
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
  
