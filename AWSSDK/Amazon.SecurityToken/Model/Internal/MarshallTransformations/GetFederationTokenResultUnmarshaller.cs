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
using System.Collections.Generic;

using Amazon.SecurityToken.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   GetFederationTokenResult Unmarshaller
     /// </summary>
    internal class GetFederationTokenResultUnmarshaller : IUnmarshaller<GetFederationTokenResult, XmlUnmarshallerContext>, IUnmarshaller<GetFederationTokenResult, JsonUnmarshallerContext> 
    {
        public GetFederationTokenResult Unmarshall(XmlUnmarshallerContext context) 
        {
            GetFederationTokenResult getFederationTokenResult = new GetFederationTokenResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Credentials", targetDepth))
                    {
                        getFederationTokenResult.Credentials = CredentialsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("FederatedUser", targetDepth))
                    {
                        getFederationTokenResult.FederatedUser = FederatedUserUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PackedPolicySize", targetDepth))
                    {
                        getFederationTokenResult.PackedPolicySize = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return getFederationTokenResult;
                }
            }
                        


            return getFederationTokenResult;
        }

        public GetFederationTokenResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static GetFederationTokenResultUnmarshaller instance;

        public static GetFederationTokenResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new GetFederationTokenResultUnmarshaller();

            return instance;
        }
    }
}
    
