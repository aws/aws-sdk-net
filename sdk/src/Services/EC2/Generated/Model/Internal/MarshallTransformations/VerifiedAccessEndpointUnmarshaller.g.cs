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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VerifiedAccessEndpoint Object
    /// </summary>
    public partial class VerifiedAccessEndpointUnmarshaller : IXmlUnmarshaller<VerifiedAccessEndpoint, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public VerifiedAccessEndpoint Unmarshall(XmlUnmarshallerContext context)
        {
            VerifiedAccessEndpoint unmarshalledObject = new VerifiedAccessEndpoint();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("applicationDomain", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ApplicationDomain = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("attachmentType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AttachmentType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("cidrOptions", targetDepth))
                    {
                        var unmarshaller = VerifiedAccessEndpointCidrOptionsUnmarshaller.Instance;
                        unmarshalledObject.CidrOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("creationTime", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("deletionTime", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeletionTime = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("deviceValidationDomain", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeviceValidationDomain = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("domainCertificateArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DomainCertificateArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("endpointDomain", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EndpointDomain = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("endpointType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EndpointType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("lastUpdatedTime", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LastUpdatedTime = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("loadBalancerOptions", targetDepth))
                    {
                        var unmarshaller = VerifiedAccessEndpointLoadBalancerOptionsUnmarshaller.Instance;
                        unmarshalledObject.LoadBalancerOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("networkInterfaceOptions", targetDepth))
                    {
                        var unmarshaller = VerifiedAccessEndpointEniOptionsUnmarshaller.Instance;
                        unmarshalledObject.NetworkInterfaceOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("rdsOptions", targetDepth))
                    {
                        var unmarshaller = VerifiedAccessEndpointRdsOptionsUnmarshaller.Instance;
                        unmarshalledObject.RdsOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("securityGroupIdSet/item", targetDepth))
                    {
                        if (unmarshalledObject.SecurityGroupIds == null)
                        {
                            unmarshalledObject.SecurityGroupIds = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SecurityGroupIds.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("sseSpecification", targetDepth))
                    {
                        var unmarshaller = VerifiedAccessSseSpecificationResponseUnmarshaller.Instance;
                        unmarshalledObject.SseSpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("status", targetDepth))
                    {
                        var unmarshaller = VerifiedAccessEndpointStatusUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var unmarshaller = TagUnmarshaller.Instance;
                        unmarshalledObject.Tags.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("verifiedAccessEndpointId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VerifiedAccessEndpointId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("verifiedAccessGroupId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VerifiedAccessGroupId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("verifiedAccessInstanceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VerifiedAccessInstanceId = unmarshaller.Unmarshall(context);
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

        private static VerifiedAccessEndpointUnmarshaller _instance = new VerifiedAccessEndpointUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static VerifiedAccessEndpointUnmarshaller Instance => _instance;
    }
}
