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
    using Amazon.CloudTrail.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// TrailUnmarshaller
      /// </summary>
      internal class TrailUnmarshaller : IUnmarshaller<Trail, XmlUnmarshallerContext>, IUnmarshaller<Trail, JsonUnmarshallerContext>
      {
        Trail IUnmarshaller<Trail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Trail Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            Trail trail = new Trail();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("Name", targetDepth))
              {
                context.Read();
                trail.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("S3BucketName", targetDepth))
              {
                context.Read();
                trail.S3BucketName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("S3KeyPrefix", targetDepth))
              {
                context.Read();
                trail.S3KeyPrefix = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SnsTopicName", targetDepth))
              {
                context.Read();
                trail.SnsTopicName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("IncludeGlobalServiceEvents", targetDepth))
              {
                context.Read();
                trail.IncludeGlobalServiceEvents = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return trail;
                }
            }
          

            return trail;
        }

        private static TrailUnmarshaller instance;
        public static TrailUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new TrailUnmarshaller();
            return instance;
        }
    }
}
  
