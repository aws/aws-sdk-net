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
      /// UpdateItemResultUnmarshaller 
      /// </summary> 
      internal class UpdateItemResultUnmarshaller : IUnmarshaller<UpdateItemResult, XmlUnmarshallerContext>, IUnmarshaller<UpdateItemResult, JsonUnmarshallerContext> 
      { 
        UpdateItemResult IUnmarshaller<UpdateItemResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public UpdateItemResult Unmarshall(JsonUnmarshallerContext context) 
        {
            UpdateItemResult updateItemResult = new UpdateItemResult();
          updateItemResult.Attributes = null; 
                                  
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
                updateItemResult.Attributes = new Dictionary<String,AttributeValue>();
                KeyValueUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>(StringUnmarshaller.GetInstance(), AttributeValueUnmarshaller.GetInstance());
                while (context.Read())
                {
                  if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                      ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                  {
                    KeyValuePair<string, AttributeValue> kvp = unmarshaller.Unmarshall(context);
                    updateItemResult.Attributes.Add(kvp.Key, kvp.Value);
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
                updateItemResult.ConsumedCapacityUnits = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return updateItemResult; 
                } 
            } 
          
          
            return updateItemResult; 
        } 
        
        private static UpdateItemResultUnmarshaller instance; 
        public static UpdateItemResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new UpdateItemResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
