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
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// SelfUserProfileUnmarshaller
      /// </summary>
      internal class SelfUserProfileUnmarshaller : IUnmarshaller<SelfUserProfile, XmlUnmarshallerContext>, IUnmarshaller<SelfUserProfile, JsonUnmarshallerContext>
      {
        SelfUserProfile IUnmarshaller<SelfUserProfile, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public SelfUserProfile Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            SelfUserProfile selfUserProfile = new SelfUserProfile();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("IamUserArn", targetDepth))
              {
                selfUserProfile.IamUserArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                selfUserProfile.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SshUsername", targetDepth))
              {
                selfUserProfile.SshUsername = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SshPublicKey", targetDepth))
              {
                selfUserProfile.SshPublicKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return selfUserProfile;
                }
            }
          

            return selfUserProfile;
        }

        private static SelfUserProfileUnmarshaller instance;
        public static SelfUserProfileUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new SelfUserProfileUnmarshaller();
            return instance;
        }
    }
}
  
