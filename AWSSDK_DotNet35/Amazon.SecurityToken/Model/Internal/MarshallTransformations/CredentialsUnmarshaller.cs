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
     ///   Credentials Unmarshaller
     /// </summary>
    internal class CredentialsUnmarshaller : IUnmarshaller<Credentials, XmlUnmarshallerContext>, IUnmarshaller<Credentials, JsonUnmarshallerContext> 
    {
        public Credentials Unmarshall(XmlUnmarshallerContext context) 
        {
            Credentials credentials = new Credentials();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AccessKeyId", targetDepth))
                    {
                        credentials.AccessKeyId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SecretAccessKey", targetDepth))
                    {
                        credentials.SecretAccessKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SessionToken", targetDepth))
                    {
                        credentials.SessionToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Expiration", targetDepth))
                    {
                        credentials.Expiration = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return credentials;
                }
            }
                        


            return credentials;
        }

        public Credentials Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CredentialsUnmarshaller instance;

        public static CredentialsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CredentialsUnmarshaller();

            return instance;
        }
    }
}
    
