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
    using ThirdParty.Json.LitJson;
    using Amazon.Kinesis.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// StreamDescriptionUnmarshaller
      /// </summary>
      internal class StreamDescriptionUnmarshaller : IUnmarshaller<StreamDescription, XmlUnmarshallerContext>, IUnmarshaller<StreamDescription, JsonUnmarshallerContext>
      {
        StreamDescription IUnmarshaller<StreamDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public StreamDescription Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            StreamDescription streamDescription = new StreamDescription();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("StreamName", targetDepth))
              {
                context.Read();
                streamDescription.StreamName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StreamARN", targetDepth))
              {
                context.Read();
                streamDescription.StreamARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StreamStatus", targetDepth))
              {
                context.Read();
                streamDescription.StreamStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Shards", targetDepth))
              {
                context.Read();
                streamDescription.Shards = new List<Shard>();
                        ShardUnmarshaller unmarshaller = ShardUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   streamDescription.Shards.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("HasMoreShards", targetDepth))
              {
                context.Read();
                streamDescription.HasMoreShards = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return streamDescription;
                }
            }
          

            return streamDescription;
        }

        private static StreamDescriptionUnmarshaller instance;
        public static StreamDescriptionUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new StreamDescriptionUnmarshaller();
            return instance;
        }
    }
}
  
