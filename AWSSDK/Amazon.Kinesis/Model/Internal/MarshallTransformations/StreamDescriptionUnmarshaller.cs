/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            StreamDescription streamDescription = new StreamDescription();
          streamDescription.Shards = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("StreamName", targetDepth))
              {
                streamDescription.StreamName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StreamARN", targetDepth))
              {
                streamDescription.StreamARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StreamStatus", targetDepth))
              {
                streamDescription.StreamStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Shards", targetDepth))
              {
                streamDescription.Shards = new List<Shard>();   
                if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                {
                  continue;
                }              

                  ShardUnmarshaller unmarshaller = ShardUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     streamDescription.Shards.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("HasMoreShards", targetDepth))
              {
                streamDescription.HasMoreShards = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
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
  
