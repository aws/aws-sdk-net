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
    using Amazon.CloudTrail.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// CreateTrailResultUnmarshaller
      /// </summary>
      internal class CreateTrailResultUnmarshaller : IUnmarshaller<CreateTrailResult, XmlUnmarshallerContext>, IUnmarshaller<CreateTrailResult, JsonUnmarshallerContext>
      {
        CreateTrailResult IUnmarshaller<CreateTrailResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public CreateTrailResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            CreateTrailResult createTrailResult = new CreateTrailResult();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Name", targetDepth))
              {
                createTrailResult.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("S3BucketName", targetDepth))
              {
                createTrailResult.S3BucketName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("S3KeyPrefix", targetDepth))
              {
                createTrailResult.S3KeyPrefix = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SnsTopicName", targetDepth))
              {
                createTrailResult.SnsTopicName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("IncludeGlobalServiceEvents", targetDepth))
              {
                createTrailResult.IncludeGlobalServiceEvents = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Trail", targetDepth))
              {
                createTrailResult.Trail = TrailUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return createTrailResult;
                }
            }
          

            return createTrailResult;
        }

        private static CreateTrailResultUnmarshaller instance;
        public static CreateTrailResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CreateTrailResultUnmarshaller();
            return instance;
        }
    }
}
  
