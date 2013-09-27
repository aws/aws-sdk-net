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
    using Amazon.DataPipeline.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// QueryObjectsResultUnmarshaller
      /// </summary>
      internal class QueryObjectsResultUnmarshaller : IUnmarshaller<QueryObjectsResult, XmlUnmarshallerContext>, IUnmarshaller<QueryObjectsResult, JsonUnmarshallerContext>
      {
        QueryObjectsResult IUnmarshaller<QueryObjectsResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public QueryObjectsResult Unmarshall(JsonUnmarshallerContext context)
        {
            QueryObjectsResult queryObjectsResult = new QueryObjectsResult();
          queryObjectsResult.Ids = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Ids", targetDepth))
              {
                queryObjectsResult.Ids = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     queryObjectsResult.Ids.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("Marker", targetDepth))
              {
                queryObjectsResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("HasMoreResults", targetDepth))
              {
                queryObjectsResult.HasMoreResults = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return queryObjectsResult;
                }
            }
          

            return queryObjectsResult;
        }

        private static QueryObjectsResultUnmarshaller instance;
        public static QueryObjectsResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new QueryObjectsResultUnmarshaller();
            return instance;
        }
    }
}
  
