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
    /// Response Unmarshaller for FlexCostAllocationPolicyAssociationDescription Object
    /// </summary>
    public partial class FlexCostAllocationPolicyAssociationDescriptionUnmarshaller : IXmlUnmarshaller<FlexCostAllocationPolicyAssociationDescription, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public FlexCostAllocationPolicyAssociationDescription Unmarshall(XmlUnmarshallerContext context)
        {
            FlexCostAllocationPolicyAssociationDescription unmarshalledObject = new FlexCostAllocationPolicyAssociationDescription();
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
                    if (context.TestExpression("associatedAt", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.AssociatedAt = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("associationMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AssociationMode = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("expectedEffectiveAt", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.ExpectedEffectiveAt = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("fcaPolicyAssociationId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FcaPolicyAssociationId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("fcaPolicyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FcaPolicyId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("managedBy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ManagedBy = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("networkResourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ownerAccount", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerAccount = unmarshaller.Unmarshall(context);
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

        private static FlexCostAllocationPolicyAssociationDescriptionUnmarshaller _instance = new FlexCostAllocationPolicyAssociationDescriptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static FlexCostAllocationPolicyAssociationDescriptionUnmarshaller Instance => _instance;
    }
}
