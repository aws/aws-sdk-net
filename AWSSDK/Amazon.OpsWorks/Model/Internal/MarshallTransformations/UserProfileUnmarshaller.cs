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
      /// UserProfileUnmarshaller
      /// </summary>
      internal class UserProfileUnmarshaller : IUnmarshaller<UserProfile, XmlUnmarshallerContext>, IUnmarshaller<UserProfile, JsonUnmarshallerContext>
      {
        UserProfile IUnmarshaller<UserProfile, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public UserProfile Unmarshall(JsonUnmarshallerContext context)
        {
            UserProfile userProfile = new UserProfile();
          
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
                userProfile.IamUserArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                userProfile.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SshUsername", targetDepth))
              {
                userProfile.SshUsername = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SshPublicKey", targetDepth))
              {
                userProfile.SshPublicKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return userProfile;
                }
            }
          

            return userProfile;
        }

        private static UserProfileUnmarshaller instance;
        public static UserProfileUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new UserProfileUnmarshaller();
            return instance;
        }
    }
}
  
