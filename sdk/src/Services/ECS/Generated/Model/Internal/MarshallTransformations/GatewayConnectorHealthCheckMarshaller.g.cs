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

using Amazon.ECS.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GatewayConnectorHealthCheck Marshaller
    /// </summary>
    public partial class GatewayConnectorHealthCheckMarshaller : IRequestMarshaller<GatewayConnectorHealthCheck, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(GatewayConnectorHealthCheck requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetHealthCheckIntervalSeconds())
            {
                context.Writer.WritePropertyName("healthCheckIntervalSeconds");
                context.Writer.WriteNumberValue(requestObject.HealthCheckIntervalSeconds.Value);
            }

            if (requestObject.IsSetHealthCheckPath())
            {
                context.Writer.WritePropertyName("healthCheckPath");
                context.Writer.WriteStringValue(requestObject.HealthCheckPath);
            }

            if (requestObject.IsSetHealthCheckPort())
            {
                context.Writer.WritePropertyName("healthCheckPort");
                context.Writer.WriteNumberValue(requestObject.HealthCheckPort.Value);
            }

            if (requestObject.IsSetHealthCheckProtocol())
            {
                context.Writer.WritePropertyName("healthCheckProtocol");
                context.Writer.WriteStringValue(requestObject.HealthCheckProtocol);
            }

            if (requestObject.IsSetHealthCheckTimeoutSeconds())
            {
                context.Writer.WritePropertyName("healthCheckTimeoutSeconds");
                context.Writer.WriteNumberValue(requestObject.HealthCheckTimeoutSeconds.Value);
            }

            if (requestObject.IsSetHealthyThresholdCount())
            {
                context.Writer.WritePropertyName("healthyThresholdCount");
                context.Writer.WriteNumberValue(requestObject.HealthyThresholdCount.Value);
            }

            if (requestObject.IsSetMatcher())
            {
                context.Writer.WritePropertyName("matcher");
                context.Writer.WriteStartObject();

                var marshaller = GatewayConnectorHealthCheckMatcherMarshaller.Instance;
                marshaller.Marshall(requestObject.Matcher, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetUnhealthyThresholdCount())
            {
                context.Writer.WritePropertyName("unhealthyThresholdCount");
                context.Writer.WriteNumberValue(requestObject.UnhealthyThresholdCount.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static GatewayConnectorHealthCheckMarshaller Instance = new GatewayConnectorHealthCheckMarshaller();
    }
}
