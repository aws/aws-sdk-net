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
     ///   ServerCertificateMetadata Unmarshaller
     /// </summary>
    internal class ServerCertificateMetadataUnmarshaller : IUnmarshaller<ServerCertificateMetadata, XmlUnmarshallerContext> 
    {
        public ServerCertificateMetadata Unmarshall(XmlUnmarshallerContext context) 
        {
            ServerCertificateMetadata serverCertificateMetadata = new ServerCertificateMetadata();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Path", targetDepth))
                    {
                        serverCertificateMetadata.Path = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ServerCertificateName", targetDepth))
                    {
                        serverCertificateMetadata.ServerCertificateName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ServerCertificateId", targetDepth))
                    {
                        serverCertificateMetadata.ServerCertificateId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Arn", targetDepth))
                    {
                        serverCertificateMetadata.Arn = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("UploadDate", targetDepth))
                    {
                        serverCertificateMetadata.UploadDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return serverCertificateMetadata;
                }
            }
                        


            return serverCertificateMetadata;
        }

        private static ServerCertificateMetadataUnmarshaller instance;

        public static ServerCertificateMetadataUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ServerCertificateMetadataUnmarshaller();

            return instance;
        }
    }
}
    
