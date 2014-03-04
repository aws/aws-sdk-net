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
      /// DeleteItemResultUnmarshaller 
      /// </summary> 
      internal class DeleteItemResultUnmarshaller : IUnmarshaller<DeleteItemResult, XmlUnmarshallerContext>, IUnmarshaller<DeleteItemResult, JsonUnmarshallerContext> 
      { 
        DeleteItemResult IUnmarshaller<DeleteItemResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DeleteItemResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DeleteItemResult deleteItemResult = new DeleteItemResult();
          deleteItemResult.Attributes = null; 
                                  
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("Attributes", targetDepth)) 
              {
                deleteItemResult.Attributes = new Dictionary<String,AttributeValue>();
                KeyValueUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>(StringUnmarshaller.GetInstance(), AttributeValueUnmarshaller.GetInstance());
                while (context.Read())
                {
                  if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                      ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                  {
                    KeyValuePair<string, AttributeValue> kvp = unmarshaller.Unmarshall(context);
                    deleteItemResult.Attributes.Add(kvp.Key, kvp.Value);
                  }
                  else if (context.IsEndElement)
                  {
                    break;
                  }
                }
                continue; 
              }
   
              if (context.TestExpression("ConsumedCapacityUnits", targetDepth)) 
              {
                deleteItemResult.ConsumedCapacityUnits = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return deleteItemResult; 
                } 
            } 
          
          
            return deleteItemResult; 
        } 
        
        private static DeleteItemResultUnmarshaller instance; 
        public static DeleteItemResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DeleteItemResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
