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
    /// AwsEc2VpcEndpointServiceDetails Marshaller
    /// </summary>
    public class AwsEc2VpcEndpointServiceDetailsMarshaller : IRequestMarshaller<AwsEc2VpcEndpointServiceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2VpcEndpointServiceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAcceptanceRequired())
            {
                context.Writer.WritePropertyName("AcceptanceRequired");
                context.Writer.WriteBooleanValue(requestObject.AcceptanceRequired.Value);
            }

            if(requestObject.IsSetAvailabilityZones())
            {
                context.Writer.WritePropertyName("AvailabilityZones");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAvailabilityZonesListValue in requestObject.AvailabilityZones)
                {
                        context.Writer.WriteStringValue(requestObjectAvailabilityZonesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBaseEndpointDnsNames())
            {
                context.Writer.WritePropertyName("BaseEndpointDnsNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBaseEndpointDnsNamesListValue in requestObject.BaseEndpointDnsNames)
                {
                        context.Writer.WriteStringValue(requestObjectBaseEndpointDnsNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGatewayLoadBalancerArns())
            {
                context.Writer.WritePropertyName("GatewayLoadBalancerArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGatewayLoadBalancerArnsListValue in requestObject.GatewayLoadBalancerArns)
                {
                        context.Writer.WriteStringValue(requestObjectGatewayLoadBalancerArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetManagesVpcEndpoints())
            {
                context.Writer.WritePropertyName("ManagesVpcEndpoints");
                context.Writer.WriteBooleanValue(requestObject.ManagesVpcEndpoints.Value);
            }

            if(requestObject.IsSetNetworkLoadBalancerArns())
            {
                context.Writer.WritePropertyName("NetworkLoadBalancerArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkLoadBalancerArnsListValue in requestObject.NetworkLoadBalancerArns)
                {
                        context.Writer.WriteStringValue(requestObjectNetworkLoadBalancerArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPrivateDnsName())
            {
                context.Writer.WritePropertyName("PrivateDnsName");
                context.Writer.WriteStringValue(requestObject.PrivateDnsName);
            }

            if(requestObject.IsSetServiceId())
            {
                context.Writer.WritePropertyName("ServiceId");
                context.Writer.WriteStringValue(requestObject.ServiceId);
            }

            if(requestObject.IsSetServiceName())
            {
                context.Writer.WritePropertyName("ServiceName");
                context.Writer.WriteStringValue(requestObject.ServiceName);
            }

            if(requestObject.IsSetServiceState())
            {
                context.Writer.WritePropertyName("ServiceState");
                context.Writer.WriteStringValue(requestObject.ServiceState);
            }

            if(requestObject.IsSetServiceType())
            {
                context.Writer.WritePropertyName("ServiceType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectServiceTypeListValue in requestObject.ServiceType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2VpcEndpointServiceServiceTypeDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectServiceTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2VpcEndpointServiceDetailsMarshaller Instance = new AwsEc2VpcEndpointServiceDetailsMarshaller();

    }
}