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
    using Amazon.Kinesis.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// GetRecordsResultUnmarshaller
      /// </summary>
      internal class GetRecordsResultUnmarshaller : IUnmarshaller<GetRecordsResult, XmlUnmarshallerContext>, IUnmarshaller<GetRecordsResult, JsonUnmarshallerContext>
      {
        GetRecordsResult IUnmarshaller<GetRecordsResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public GetRecordsResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            GetRecordsResult getRecordsResult = new GetRecordsResult();
          getRecordsResult.Records = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Records", targetDepth))
              {
                getRecordsResult.Records = new List<Record>();
                        RecordUnmarshaller unmarshaller = RecordUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     getRecordsResult.Records.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("NextShardIterator", targetDepth))
              {
                getRecordsResult.NextShardIterator = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return getRecordsResult;
                }
            }
          

            return getRecordsResult;
        }

        private static GetRecordsResultUnmarshaller instance;
        public static GetRecordsResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new GetRecordsResultUnmarshaller();
            return instance;
        }
    }
}
  
