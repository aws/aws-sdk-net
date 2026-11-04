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
    /// Response Unmarshaller for ReplicationGroupPendingModifiedValues Object
    /// </summary>
    public partial class ReplicationGroupPendingModifiedValuesUnmarshaller : IXmlUnmarshaller<ReplicationGroupPendingModifiedValues, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ReplicationGroupPendingModifiedValues Unmarshall(XmlUnmarshallerContext context)
        {
            ReplicationGroupPendingModifiedValues unmarshalledObject = new ReplicationGroupPendingModifiedValues();
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
                    if (context.TestExpression("AuthTokenStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AuthTokenStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("AutomaticFailoverStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AutomaticFailoverStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ClusterMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClusterMode = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("LogDeliveryConfigurations/member", targetDepth))
                    {
                        if (unmarshalledObject.LogDeliveryConfigurations == null)
                        {
                            unmarshalledObject.LogDeliveryConfigurations = new List<PendingLogDeliveryConfiguration>();
                        }
                        var unmarshaller = PendingLogDeliveryConfigurationUnmarshaller.Instance;
                        unmarshalledObject.LogDeliveryConfigurations.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("PrimaryClusterId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PrimaryClusterId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Resharding", targetDepth))
                    {
                        var unmarshaller = ReshardingStatusUnmarshaller.Instance;
                        unmarshalledObject.Resharding = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("TransitEncryptionEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.TransitEncryptionEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("TransitEncryptionMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TransitEncryptionMode = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("UserGroups", targetDepth))
                    {
                        var unmarshaller = UserGroupsUpdateStatusUnmarshaller.Instance;
                        unmarshalledObject.UserGroups = unmarshaller.Unmarshall(context);
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

        private static ReplicationGroupPendingModifiedValuesUnmarshaller _instance = new ReplicationGroupPendingModifiedValuesUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ReplicationGroupPendingModifiedValuesUnmarshaller Instance => _instance;
    }
}
