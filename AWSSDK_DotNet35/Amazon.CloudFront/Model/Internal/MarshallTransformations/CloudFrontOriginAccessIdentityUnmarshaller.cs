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

using Amazon.CloudFront.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   CloudFrontOriginAccessIdentity Unmarshaller
     /// </summary>
    internal class CloudFrontOriginAccessIdentityUnmarshaller : IUnmarshaller<CloudFrontOriginAccessIdentity, XmlUnmarshallerContext>, IUnmarshaller<CloudFrontOriginAccessIdentity, JsonUnmarshallerContext> 
    {
        public CloudFrontOriginAccessIdentity Unmarshall(XmlUnmarshallerContext context) 
        {
            CloudFrontOriginAccessIdentity cloudFrontOriginAccessIdentity = new CloudFrontOriginAccessIdentity();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Id", targetDepth))
                    {
                        cloudFrontOriginAccessIdentity.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("S3CanonicalUserId", targetDepth))
                    {
                        cloudFrontOriginAccessIdentity.S3CanonicalUserId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CloudFrontOriginAccessIdentityConfig", targetDepth))
                    {
                        cloudFrontOriginAccessIdentity.CloudFrontOriginAccessIdentityConfig = CloudFrontOriginAccessIdentityConfigUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cloudFrontOriginAccessIdentity;
                }
            }
                        


            return cloudFrontOriginAccessIdentity;
        }

        public CloudFrontOriginAccessIdentity Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CloudFrontOriginAccessIdentityUnmarshaller instance;

        public static CloudFrontOriginAccessIdentityUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CloudFrontOriginAccessIdentityUnmarshaller();

            return instance;
        }
    }
}
    
