/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DistributionConfig Object
    /// </summary>  
    public class DistributionConfigUnmarshaller : IXmlUnmarshaller<DistributionConfig, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DistributionConfig Unmarshall(XmlUnmarshallerContext context)
        {
            DistributionConfig unmarshalledObject = new DistributionConfig();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Aliases", targetDepth))
                    {
                        var unmarshaller = AliasesUnmarshaller.Instance;
                        unmarshalledObject.Aliases = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CacheBehaviors", targetDepth))
                    {
                        var unmarshaller = CacheBehaviorsUnmarshaller.Instance;
                        unmarshalledObject.CacheBehaviors = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CallerReference", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CallerReference = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Comment", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Comment = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ContinuousDeploymentPolicyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ContinuousDeploymentPolicyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CustomErrorResponses", targetDepth))
                    {
                        var unmarshaller = CustomErrorResponsesUnmarshaller.Instance;
                        unmarshalledObject.CustomErrorResponses = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultCacheBehavior", targetDepth))
                    {
                        var unmarshaller = DefaultCacheBehaviorUnmarshaller.Instance;
                        unmarshalledObject.DefaultCacheBehavior = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultRootObject", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DefaultRootObject = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Enabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HttpVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HttpVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IsIPV6Enabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IsIPV6Enabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Logging", targetDepth))
                    {
                        var unmarshaller = LoggingConfigUnmarshaller.Instance;
                        unmarshalledObject.Logging = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OriginGroups", targetDepth))
                    {
                        var unmarshaller = OriginGroupsUnmarshaller.Instance;
                        unmarshalledObject.OriginGroups = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Origins", targetDepth))
                    {
                        var unmarshaller = OriginsUnmarshaller.Instance;
                        unmarshalledObject.Origins = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PriceClass", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PriceClass = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Restrictions", targetDepth))
                    {
                        var unmarshaller = RestrictionsUnmarshaller.Instance;
                        unmarshalledObject.Restrictions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Staging", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Staging = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ViewerCertificate", targetDepth))
                    {
                        var unmarshaller = ViewerCertificateUnmarshaller.Instance;
                        unmarshalledObject.ViewerCertificate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("WebACLId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.WebACLId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }
        private static DistributionConfigUnmarshaller _instance = new DistributionConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DistributionConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}