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
    /// Response Unmarshaller for FlexCostAllocationPolicyDescription Object
    /// </summary>
    public partial class FlexCostAllocationPolicyDescriptionUnmarshaller : IXmlUnmarshaller<FlexCostAllocationPolicyDescription, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public FlexCostAllocationPolicyDescription Unmarshall(XmlUnmarshallerContext context)
        {
            FlexCostAllocationPolicyDescription unmarshalledObject = new FlexCostAllocationPolicyDescription();
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
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("fcaPolicyArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FcaPolicyArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("fcaPolicyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FcaPolicyId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("instanceFcaPolicyDocument", targetDepth))
                    {
                        var unmarshaller = InstanceFlexCostAllocationPolicyDocumentUnmarshaller.Instance;
                        unmarshalledObject.InstanceFcaPolicyDocument = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("latestVersion", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.LatestVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("managedBy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ManagedBy = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("natFcaPolicyDocument", targetDepth))
                    {
                        var unmarshaller = NatFlexCostAllocationPolicyDocumentUnmarshaller.Instance;
                        unmarshalledObject.NatFcaPolicyDocument = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("networkResourceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkResourceType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ownerAccount", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerAccount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("pcxFcaPolicyDocument", targetDepth))
                    {
                        var unmarshaller = PcxFlexCostAllocationPolicyDocumentUnmarshaller.Instance;
                        unmarshalledObject.PcxFcaPolicyDocument = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("policyCreatedAt", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.PolicyCreatedAt = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("showBackEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.ShowBackEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("tags/item", targetDepth))
                    {
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var unmarshaller = TagUnmarshaller.Instance;
                        unmarshalledObject.Tags.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("updatedAt", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("versionExpectedEffectiveAt", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.VersionExpectedEffectiveAt = unmarshaller.Unmarshall(context);
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

        private static FlexCostAllocationPolicyDescriptionUnmarshaller _instance = new FlexCostAllocationPolicyDescriptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static FlexCostAllocationPolicyDescriptionUnmarshaller Instance => _instance;
    }
}
