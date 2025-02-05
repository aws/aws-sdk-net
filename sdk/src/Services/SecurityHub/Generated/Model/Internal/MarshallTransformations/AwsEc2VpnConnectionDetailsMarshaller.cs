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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEc2VpnConnectionDetails Marshaller
    /// </summary>
    public class AwsEc2VpnConnectionDetailsMarshaller : IRequestMarshaller<AwsEc2VpnConnectionDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2VpnConnectionDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCategory())
            {
                context.Writer.WritePropertyName("Category");
                context.Writer.WriteStringValue(requestObject.Category);
            }

            if(requestObject.IsSetCustomerGatewayConfiguration())
            {
                context.Writer.WritePropertyName("CustomerGatewayConfiguration");
                context.Writer.WriteStringValue(requestObject.CustomerGatewayConfiguration);
            }

            if(requestObject.IsSetCustomerGatewayId())
            {
                context.Writer.WritePropertyName("CustomerGatewayId");
                context.Writer.WriteStringValue(requestObject.CustomerGatewayId);
            }

            if(requestObject.IsSetOptions())
            {
                context.Writer.WritePropertyName("Options");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2VpnConnectionOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Options, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoutes())
            {
                context.Writer.WritePropertyName("Routes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRoutesListValue in requestObject.Routes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2VpnConnectionRoutesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectRoutesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteStringValue(requestObject.State);
            }

            if(requestObject.IsSetTransitGatewayId())
            {
                context.Writer.WritePropertyName("TransitGatewayId");
                context.Writer.WriteStringValue(requestObject.TransitGatewayId);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if(requestObject.IsSetVgwTelemetry())
            {
                context.Writer.WritePropertyName("VgwTelemetry");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVgwTelemetryListValue in requestObject.VgwTelemetry)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2VpnConnectionVgwTelemetryDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectVgwTelemetryListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVpnConnectionId())
            {
                context.Writer.WritePropertyName("VpnConnectionId");
                context.Writer.WriteStringValue(requestObject.VpnConnectionId);
            }

            if(requestObject.IsSetVpnGatewayId())
            {
                context.Writer.WritePropertyName("VpnGatewayId");
                context.Writer.WriteStringValue(requestObject.VpnGatewayId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2VpnConnectionDetailsMarshaller Instance = new AwsEc2VpnConnectionDetailsMarshaller();

    }
}