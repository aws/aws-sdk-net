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
      /// KeyUnmarshaller 
      /// </summary> 
      internal class KeyUnmarshaller : IUnmarshaller<Key, XmlUnmarshallerContext>, IUnmarshaller<Key, JsonUnmarshallerContext> 
      { 
        Key IUnmarshaller<Key, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public Key Unmarshall(JsonUnmarshallerContext context) 
        {
            Key key = new Key();
                    
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
                key.HashKeyElement = AttributeValueUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("RangeKeyElement", targetDepth)) 
              {
                key.RangeKeyElement = AttributeValueUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return key; 
                } 
            } 
          
          
            return key; 
        } 
        
        private static KeyUnmarshaller instance; 
        public static KeyUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new KeyUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
