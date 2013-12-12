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
      /// PutRecordResultUnmarshaller
      /// </summary>
      internal class PutRecordResultUnmarshaller : IUnmarshaller<PutRecordResult, XmlUnmarshallerContext>, IUnmarshaller<PutRecordResult, JsonUnmarshallerContext>
      {
        PutRecordResult IUnmarshaller<PutRecordResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public PutRecordResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            PutRecordResult putRecordResult = new PutRecordResult();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("ShardId", targetDepth))
              {
                putRecordResult.ShardId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SequenceNumber", targetDepth))
              {
                putRecordResult.SequenceNumber = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return putRecordResult;
                }
            }
          

            return putRecordResult;
        }

        private static PutRecordResultUnmarshaller instance;
        public static PutRecordResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PutRecordResultUnmarshaller();
            return instance;
        }
    }
}
  
