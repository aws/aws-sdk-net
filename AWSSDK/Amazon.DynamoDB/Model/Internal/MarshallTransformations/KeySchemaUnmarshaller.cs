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
    using Amazon.DynamoDB.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DynamoDB.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// KeySchemaUnmarshaller 
      /// </summary> 
      internal class KeySchemaUnmarshaller : IUnmarshaller<KeySchema, XmlUnmarshallerContext>, IUnmarshaller<KeySchema, JsonUnmarshallerContext> 
      { 
        KeySchema IUnmarshaller<KeySchema, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public KeySchema Unmarshall(JsonUnmarshallerContext context) 
        {
            KeySchema keySchema = new KeySchema();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("HashKeyElement", targetDepth)) 
              {
                keySchema.HashKeyElement = KeySchemaElementUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("RangeKeyElement", targetDepth)) 
              {
                keySchema.RangeKeyElement = KeySchemaElementUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return keySchema; 
                } 
            } 
          
          
            return keySchema; 
        } 
        
        private static KeySchemaUnmarshaller instance; 
        public static KeySchemaUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new KeySchemaUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
