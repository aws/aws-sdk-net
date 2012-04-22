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
      /// WriteRequestUnmarshaller 
      /// </summary> 
      internal class WriteRequestUnmarshaller : IUnmarshaller<WriteRequest, XmlUnmarshallerContext>, IUnmarshaller<WriteRequest, JsonUnmarshallerContext> 
      { 
        WriteRequest IUnmarshaller<WriteRequest, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public WriteRequest Unmarshall(JsonUnmarshallerContext context) 
        { 
          WriteRequest writeRequest = new WriteRequest();
          
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("PutRequest", targetDepth)) 
              {
                writeRequest.PutRequest = PutRequestUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DeleteRequest", targetDepth)) 
              {
                writeRequest.DeleteRequest = DeleteRequestUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return writeRequest; 
            } 
          } 
          return writeRequest; 
        } 
        
        private static WriteRequestUnmarshaller instance; 
        public static WriteRequestUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new WriteRequestUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
