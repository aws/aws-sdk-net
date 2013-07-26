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

using Amazon.IdentityManagement.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   SigningCertificate Unmarshaller
     /// </summary>
    internal class SigningCertificateUnmarshaller : IUnmarshaller<SigningCertificate, XmlUnmarshallerContext>, IUnmarshaller<SigningCertificate, JsonUnmarshallerContext> 
    {
        public SigningCertificate Unmarshall(XmlUnmarshallerContext context) 
        {
            SigningCertificate signingCertificate = new SigningCertificate();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("UserName", targetDepth))
                    {
                        signingCertificate.UserName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CertificateId", targetDepth))
                    {
                        signingCertificate.CertificateId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CertificateBody", targetDepth))
                    {
                        signingCertificate.CertificateBody = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        signingCertificate.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("UploadDate", targetDepth))
                    {
                        signingCertificate.UploadDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return signingCertificate;
                }
            }
                        


            return signingCertificate;
        }

        public SigningCertificate Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SigningCertificateUnmarshaller instance;

        public static SigningCertificateUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SigningCertificateUnmarshaller();

            return instance;
        }
    }
}
    
