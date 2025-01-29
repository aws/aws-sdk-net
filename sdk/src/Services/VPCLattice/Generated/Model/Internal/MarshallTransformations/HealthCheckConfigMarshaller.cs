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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VPCLattice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.VPCLattice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HealthCheckConfig Marshaller
    /// </summary>
    public class HealthCheckConfigMarshaller : IRequestMarshaller<HealthCheckConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HealthCheckConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("enabled");
                context.Writer.WriteBooleanValue(requestObject.Enabled.Value);
            }

            if(requestObject.IsSetHealthCheckIntervalSeconds())
            {
                context.Writer.WritePropertyName("healthCheckIntervalSeconds");
                context.Writer.WriteNumberValue(requestObject.HealthCheckIntervalSeconds.Value);
            }

            if(requestObject.IsSetHealthCheckTimeoutSeconds())
            {
                context.Writer.WritePropertyName("healthCheckTimeoutSeconds");
                context.Writer.WriteNumberValue(requestObject.HealthCheckTimeoutSeconds.Value);
            }

            if(requestObject.IsSetHealthyThresholdCount())
            {
                context.Writer.WritePropertyName("healthyThresholdCount");
                context.Writer.WriteNumberValue(requestObject.HealthyThresholdCount.Value);
            }

            if(requestObject.IsSetMatcher())
            {
                context.Writer.WritePropertyName("matcher");
                context.Writer.WriteStartObject();

                var marshaller = MatcherMarshaller.Instance;
                marshaller.Marshall(requestObject.Matcher, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("path");
                context.Writer.WriteStringValue(requestObject.Path);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("protocol");
                context.Writer.WriteStringValue(requestObject.Protocol);
            }

            if(requestObject.IsSetProtocolVersion())
            {
                context.Writer.WritePropertyName("protocolVersion");
                context.Writer.WriteStringValue(requestObject.ProtocolVersion);
            }

            if(requestObject.IsSetUnhealthyThresholdCount())
            {
                context.Writer.WritePropertyName("unhealthyThresholdCount");
                context.Writer.WriteNumberValue(requestObject.UnhealthyThresholdCount.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HealthCheckConfigMarshaller Instance = new HealthCheckConfigMarshaller();

    }
}