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
     ///   CloudFrontOriginAccessIdentitySummary Unmarshaller
     /// </summary>
    internal class CloudFrontOriginAccessIdentitySummaryUnmarshaller : IUnmarshaller<CloudFrontOriginAccessIdentitySummary, XmlUnmarshallerContext>, IUnmarshaller<CloudFrontOriginAccessIdentitySummary, JsonUnmarshallerContext> 
    {
        public CloudFrontOriginAccessIdentitySummary Unmarshall(XmlUnmarshallerContext context) 
        {
            CloudFrontOriginAccessIdentitySummary cloudFrontOriginAccessIdentitySummary = new CloudFrontOriginAccessIdentitySummary();
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
                        cloudFrontOriginAccessIdentitySummary.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("S3CanonicalUserId", targetDepth))
                    {
                        cloudFrontOriginAccessIdentitySummary.S3CanonicalUserId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Comment", targetDepth))
                    {
                        cloudFrontOriginAccessIdentitySummary.Comment = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cloudFrontOriginAccessIdentitySummary;
                }
            }
                        


            return cloudFrontOriginAccessIdentitySummary;
        }

        public CloudFrontOriginAccessIdentitySummary Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CloudFrontOriginAccessIdentitySummaryUnmarshaller instance;

        public static CloudFrontOriginAccessIdentitySummaryUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CloudFrontOriginAccessIdentitySummaryUnmarshaller();

            return instance;
        }
    }
}
    
