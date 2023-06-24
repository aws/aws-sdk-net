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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAvailabilityZones())
            {
                context.Writer.WritePropertyName("AvailabilityZones");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAvailabilityZonesListValue in requestObject.AvailabilityZones)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AvailabilityZoneMarshaller.Instance;
                    marshaller.Marshall(requestObjectAvailabilityZonesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCanonicalHostedZoneId())
            {
                context.Writer.WritePropertyName("CanonicalHostedZoneId");
                context.Writer.Write(requestObject.CanonicalHostedZoneId);
            }

            if(requestObject.IsSetCreatedTime())
            {
                context.Writer.WritePropertyName("CreatedTime");
                context.Writer.Write(requestObject.CreatedTime);
            }

            if(requestObject.IsSetDNSName())
            {
                context.Writer.WritePropertyName("DNSName");
                context.Writer.Write(requestObject.DNSName);
            }

            if(requestObject.IsSetIpAddressType())
            {
                context.Writer.WritePropertyName("IpAddressType");
                context.Writer.Write(requestObject.IpAddressType);
            }

            if(requestObject.IsSetLoadBalancerAttributes())
            {
                context.Writer.WritePropertyName("LoadBalancerAttributes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLoadBalancerAttributesListValue in requestObject.LoadBalancerAttributes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsElbv2LoadBalancerAttributeMarshaller.Instance;
                    marshaller.Marshall(requestObjectLoadBalancerAttributesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScheme())
            {
                context.Writer.WritePropertyName("Scheme");
                context.Writer.Write(requestObject.Scheme);
            }

            if(requestObject.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("SecurityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                        context.Writer.Write(requestObjectSecurityGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteObjectStart();

                var marshaller = LoadBalancerStateMarshaller.Instance;
                marshaller.Marshall(requestObject.State, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.Write(requestObject.VpcId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsElbv2LoadBalancerDetailsMarshaller Instance = new AwsElbv2LoadBalancerDetailsMarshaller();

    }
}