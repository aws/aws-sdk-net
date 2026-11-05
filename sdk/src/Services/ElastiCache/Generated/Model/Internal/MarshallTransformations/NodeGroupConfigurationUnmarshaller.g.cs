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

using Amazon.ElastiCache.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NodeGroupConfiguration Object
    /// </summary>
    public partial class NodeGroupConfigurationUnmarshaller : IXmlUnmarshaller<NodeGroupConfiguration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public NodeGroupConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            NodeGroupConfiguration unmarshalledObject = new NodeGroupConfiguration();
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
                    if (context.TestExpression("NodeGroupId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NodeGroupId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PrimaryAvailabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PrimaryAvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PrimaryOutpostArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PrimaryOutpostArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ReplicaAvailabilityZones/AvailabilityZone", targetDepth))
                    {
                        if (unmarshalledObject.ReplicaAvailabilityZones == null)
                        {
                            unmarshalledObject.ReplicaAvailabilityZones = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReplicaAvailabilityZones.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ReplicaCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.ReplicaCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ReplicaOutpostArns/OutpostArn", targetDepth))
                    {
                        if (unmarshalledObject.ReplicaOutpostArns == null)
                        {
                            unmarshalledObject.ReplicaOutpostArns = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReplicaOutpostArns.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("Slots", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Slots = unmarshaller.Unmarshall(context);
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

        private static NodeGroupConfigurationUnmarshaller _instance = new NodeGroupConfigurationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static NodeGroupConfigurationUnmarshaller Instance => _instance;
    }
}
