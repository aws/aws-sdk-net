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
    /// AwsElbv2LoadBalancerDetails Marshaller
    /// </summary>
    public class AwsElbv2LoadBalancerDetailsMarshaller : IRequestMarshaller<AwsElbv2LoadBalancerDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsElbv2LoadBalancerDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAvailabilityZones())
            {
                context.Writer.WritePropertyName("AvailabilityZones");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAvailabilityZonesListValue in requestObject.AvailabilityZones)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AvailabilityZoneMarshaller.Instance;
                    marshaller.Marshall(requestObjectAvailabilityZonesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCanonicalHostedZoneId())
            {
                context.Writer.WritePropertyName("CanonicalHostedZoneId");
                context.Writer.WriteStringValue(requestObject.CanonicalHostedZoneId);
            }

            if(requestObject.IsSetCreatedTime())
            {
                context.Writer.WritePropertyName("CreatedTime");
                context.Writer.WriteStringValue(requestObject.CreatedTime);
            }

            if(requestObject.IsSetDNSName())
            {
                context.Writer.WritePropertyName("DNSName");
                context.Writer.WriteStringValue(requestObject.DNSName);
            }

            if(requestObject.IsSetIpAddressType())
            {
                context.Writer.WritePropertyName("IpAddressType");
                context.Writer.WriteStringValue(requestObject.IpAddressType);
            }

            if(requestObject.IsSetLoadBalancerAttributes())
            {
                context.Writer.WritePropertyName("LoadBalancerAttributes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLoadBalancerAttributesListValue in requestObject.LoadBalancerAttributes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsElbv2LoadBalancerAttributeMarshaller.Instance;
                    marshaller.Marshall(requestObjectLoadBalancerAttributesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScheme())
            {
                context.Writer.WritePropertyName("Scheme");
                context.Writer.WriteStringValue(requestObject.Scheme);
            }

            if(requestObject.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("SecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteStartObject();

                var marshaller = LoadBalancerStateMarshaller.Instance;
                marshaller.Marshall(requestObject.State, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.WriteStringValue(requestObject.VpcId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsElbv2LoadBalancerDetailsMarshaller Instance = new AwsElbv2LoadBalancerDetailsMarshaller();

    }
}