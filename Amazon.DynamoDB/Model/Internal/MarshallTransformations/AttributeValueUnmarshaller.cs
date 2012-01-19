/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using Amazon.DynamoDB.Model; 
    using Amazon.Runtime.Internal.Transform; 

    namespace Amazon.DynamoDB.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// AttributeValueUnmarshaller 
      /// </summary> 
      internal class AttributeValueUnmarshaller : IUnmarshaller<AttributeValue, UnmarshallerContext>, IUnmarshaller<AttributeValue, JsonUnmarshallerContext> 
      { 
        AttributeValue IUnmarshaller<AttributeValue, UnmarshallerContext>.Unmarshall(UnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public AttributeValue Unmarshall(JsonUnmarshallerContext context) 
        { 
          AttributeValue attributeValue = new AttributeValue();
          attributeValue.SS = null; 
                        attributeValue.NS = null; 
                        
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
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
   
              if (context.TestExpression("SS", targetDepth)) 
              {
                attributeValue.SS = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     attributeValue.SS.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
              if (context.TestExpression("NS", targetDepth)) 
              {
                attributeValue.NS = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     attributeValue.NS.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return attributeValue; 
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
  
