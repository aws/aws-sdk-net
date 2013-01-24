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
      /// ListTablesResultUnmarshaller 
      /// </summary> 
      internal class ListTablesResultUnmarshaller : IUnmarshaller<ListTablesResult, XmlUnmarshallerContext>, IUnmarshaller<ListTablesResult, JsonUnmarshallerContext> 
      { 
        ListTablesResult IUnmarshaller<ListTablesResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public ListTablesResult Unmarshall(JsonUnmarshallerContext context) 
        {
            ListTablesResult listTablesResult = new ListTablesResult();
          listTablesResult.TableNames = null; 
                                  
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("TableNames", targetDepth)) 
              {
                listTablesResult.TableNames = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     listTablesResult.TableNames.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
              if (context.TestExpression("LastEvaluatedTableName", targetDepth)) 
              {
                listTablesResult.LastEvaluatedTableName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return listTablesResult; 
                } 
            } 
          
          
            return listTablesResult; 
        } 
        
        private static ListTablesResultUnmarshaller instance; 
        public static ListTablesResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new ListTablesResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
