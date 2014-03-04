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
      /// ShardUnmarshaller
      /// </summary>
      internal class ShardUnmarshaller : IUnmarshaller<Shard, XmlUnmarshallerContext>, IUnmarshaller<Shard, JsonUnmarshallerContext>
      {
        Shard IUnmarshaller<Shard, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Shard Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            Shard shard = new Shard();
          
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
                shard.ShardId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ParentShardId", targetDepth))
              {
                shard.ParentShardId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AdjacentParentShardId", targetDepth))
              {
                shard.AdjacentParentShardId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("HashKeyRange", targetDepth))
              {
                shard.HashKeyRange = HashKeyRangeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SequenceNumberRange", targetDepth))
              {
                shard.SequenceNumberRange = SequenceNumberRangeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return shard;
                }
            }
          

            return shard;
        }

        private static ShardUnmarshaller instance;
        public static ShardUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ShardUnmarshaller();
            return instance;
        }
    }
}
  
