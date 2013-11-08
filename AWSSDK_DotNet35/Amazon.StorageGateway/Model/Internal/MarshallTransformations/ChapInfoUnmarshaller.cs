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
      /// ChapInfoUnmarshaller
      /// </summary>
      internal class ChapInfoUnmarshaller : IUnmarshaller<ChapInfo, XmlUnmarshallerContext>, IUnmarshaller<ChapInfo, JsonUnmarshallerContext>
      {
        ChapInfo IUnmarshaller<ChapInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ChapInfo Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            ChapInfo chapInfo = new ChapInfo();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("TargetARN", targetDepth))
              {
                context.Read();
                chapInfo.TargetARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SecretToAuthenticateInitiator", targetDepth))
              {
                context.Read();
                chapInfo.SecretToAuthenticateInitiator = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InitiatorName", targetDepth))
              {
                context.Read();
                chapInfo.InitiatorName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SecretToAuthenticateTarget", targetDepth))
              {
                context.Read();
                chapInfo.SecretToAuthenticateTarget = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return chapInfo;
                }
            }
          

            return chapInfo;
        }

        private static ChapInfoUnmarshaller instance;
        public static ChapInfoUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ChapInfoUnmarshaller();
            return instance;
        }
    }
}
  
