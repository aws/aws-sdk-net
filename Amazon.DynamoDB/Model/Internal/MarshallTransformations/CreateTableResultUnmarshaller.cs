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
      /// CreateTableResultUnmarshaller 
      /// </summary> 
      internal class CreateTableResultUnmarshaller : IUnmarshaller<CreateTableResult, UnmarshallerContext>, IUnmarshaller<CreateTableResult, JsonUnmarshallerContext> 
      { 
        CreateTableResult IUnmarshaller<CreateTableResult, UnmarshallerContext>.Unmarshall(UnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public CreateTableResult Unmarshall(JsonUnmarshallerContext context) 
        { 
          CreateTableResult createTableResult = new CreateTableResult();
          
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("TableDescription", targetDepth)) 
              {
                createTableResult.TableDescription = TableDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return createTableResult; 
            } 
          } 
          return createTableResult; 
        } 
        
        private static CreateTableResultUnmarshaller instance; 
        public static CreateTableResultUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new CreateTableResultUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
