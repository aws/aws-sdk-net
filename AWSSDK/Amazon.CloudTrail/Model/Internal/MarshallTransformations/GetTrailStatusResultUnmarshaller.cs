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
      /// GetTrailStatusResultUnmarshaller
      /// </summary>
      internal class GetTrailStatusResultUnmarshaller : IUnmarshaller<GetTrailStatusResult, XmlUnmarshallerContext>, IUnmarshaller<GetTrailStatusResult, JsonUnmarshallerContext>
      {
        GetTrailStatusResult IUnmarshaller<GetTrailStatusResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public GetTrailStatusResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            GetTrailStatusResult getTrailStatusResult = new GetTrailStatusResult();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("IsLogging", targetDepth))
              {
                getTrailStatusResult.IsLogging = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LatestDeliveryError", targetDepth))
              {
                getTrailStatusResult.LatestDeliveryError = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LatestNotificationError", targetDepth))
              {
                getTrailStatusResult.LatestNotificationError = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LatestDeliveryAttemptTime", targetDepth))
              {
                getTrailStatusResult.LatestDeliveryAttemptTime = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LatestDeliveryAttemptSucceeded", targetDepth))
              {
                getTrailStatusResult.LatestDeliveryAttemptSucceeded = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LatestNotificationAttemptTime", targetDepth))
              {
                getTrailStatusResult.LatestNotificationAttemptTime = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LatestNotificationAttemptSucceeded", targetDepth))
              {
                getTrailStatusResult.LatestNotificationAttemptSucceeded = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TimeLoggingStarted", targetDepth))
              {
                getTrailStatusResult.TimeLoggingStarted = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TimeLoggingStopped", targetDepth))
              {
                getTrailStatusResult.TimeLoggingStopped = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return getTrailStatusResult;
                }
            }
          

            return getTrailStatusResult;
        }

        private static GetTrailStatusResultUnmarshaller instance;
        public static GetTrailStatusResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new GetTrailStatusResultUnmarshaller();
            return instance;
        }
    }
}
  
