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
     ///   CloudFrontOriginAccessIdentityList Unmarshaller
     /// </summary>
    internal class CloudFrontOriginAccessIdentityListUnmarshaller : IUnmarshaller<CloudFrontOriginAccessIdentityList, XmlUnmarshallerContext>, IUnmarshaller<CloudFrontOriginAccessIdentityList, JsonUnmarshallerContext> 
    {
        public CloudFrontOriginAccessIdentityList Unmarshall(XmlUnmarshallerContext context) 
        {
            CloudFrontOriginAccessIdentityList cloudFrontOriginAccessIdentityList = new CloudFrontOriginAccessIdentityList();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        cloudFrontOriginAccessIdentityList.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("NextMarker", targetDepth))
                    {
                        cloudFrontOriginAccessIdentityList.NextMarker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MaxItems", targetDepth))
                    {
                        cloudFrontOriginAccessIdentityList.MaxItems = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        cloudFrontOriginAccessIdentityList.IsTruncated = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Quantity", targetDepth))
                    {
                        cloudFrontOriginAccessIdentityList.Quantity = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Items/CloudFrontOriginAccessIdentitySummary", targetDepth))
                    {
                        cloudFrontOriginAccessIdentityList.Items.Add(CloudFrontOriginAccessIdentitySummaryUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cloudFrontOriginAccessIdentityList;
                }
            }
                        


            return cloudFrontOriginAccessIdentityList;
        }

        public CloudFrontOriginAccessIdentityList Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CloudFrontOriginAccessIdentityListUnmarshaller instance;

        public static CloudFrontOriginAccessIdentityListUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CloudFrontOriginAccessIdentityListUnmarshaller();

            return instance;
        }
    }
}
    
