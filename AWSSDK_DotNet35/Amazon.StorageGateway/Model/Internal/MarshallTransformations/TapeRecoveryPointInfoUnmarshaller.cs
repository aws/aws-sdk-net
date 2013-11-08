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
    using Amazon.StorageGateway.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// TapeRecoveryPointInfoUnmarshaller
      /// </summary>
      internal class TapeRecoveryPointInfoUnmarshaller : IUnmarshaller<TapeRecoveryPointInfo, XmlUnmarshallerContext>, IUnmarshaller<TapeRecoveryPointInfo, JsonUnmarshallerContext>
      {
        TapeRecoveryPointInfo IUnmarshaller<TapeRecoveryPointInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public TapeRecoveryPointInfo Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            TapeRecoveryPointInfo tapeRecoveryPointInfo = new TapeRecoveryPointInfo();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("TapeARN", targetDepth))
              {
                context.Read();
                tapeRecoveryPointInfo.TapeARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TapeRecoveryPointTime", targetDepth))
              {
                context.Read();
                tapeRecoveryPointInfo.TapeRecoveryPointTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TapeSizeInBytes", targetDepth))
              {
                context.Read();
                tapeRecoveryPointInfo.TapeSizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TapeStatus", targetDepth))
              {
                context.Read();
                tapeRecoveryPointInfo.TapeStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return tapeRecoveryPointInfo;
                }
            }
          

            return tapeRecoveryPointInfo;
        }

        private static TapeRecoveryPointInfoUnmarshaller instance;
        public static TapeRecoveryPointInfoUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new TapeRecoveryPointInfoUnmarshaller();
            return instance;
        }
    }
}
  
