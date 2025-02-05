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
    /// AwsElbLoadBalancerDetails Marshaller
    /// </summary>
    public class AwsElbLoadBalancerDetailsMarshaller : IRequestMarshaller<AwsElbLoadBalancerDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsElbLoadBalancerDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
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

            if(requestObject.IsSetBackendServerDescriptions())
            {
                context.Writer.WritePropertyName("BackendServerDescriptions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBackendServerDescriptionsListValue in requestObject.BackendServerDescriptions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsElbLoadBalancerBackendServerDescriptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectBackendServerDescriptionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCanonicalHostedZoneName())
            {
                context.Writer.WritePropertyName("CanonicalHostedZoneName");
                context.Writer.WriteStringValue(requestObject.CanonicalHostedZoneName);
            }

            if(requestObject.IsSetCanonicalHostedZoneNameID())
            {
                context.Writer.WritePropertyName("CanonicalHostedZoneNameID");
                context.Writer.WriteStringValue(requestObject.CanonicalHostedZoneNameID);
            }

            if(requestObject.IsSetCreatedTime())
            {
                context.Writer.WritePropertyName("CreatedTime");
                context.Writer.WriteStringValue(requestObject.CreatedTime);
            }

            if(requestObject.IsSetDnsName())
            {
                context.Writer.WritePropertyName("DnsName");
                context.Writer.WriteStringValue(requestObject.DnsName);
            }

            if(requestObject.IsSetHealthCheck())
            {
                context.Writer.WritePropertyName("HealthCheck");
                context.Writer.WriteStartObject();

                var marshaller = AwsElbLoadBalancerHealthCheckMarshaller.Instance;
                marshaller.Marshall(requestObject.HealthCheck, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInstances())
            {
                context.Writer.WritePropertyName("Instances");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInstancesListValue in requestObject.Instances)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsElbLoadBalancerInstanceMarshaller.Instance;
                    marshaller.Marshall(requestObjectInstancesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetListenerDescriptions())
            {
                context.Writer.WritePropertyName("ListenerDescriptions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectListenerDescriptionsListValue in requestObject.ListenerDescriptions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsElbLoadBalancerListenerDescriptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectListenerDescriptionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLoadBalancerAttributes())
            {
                context.Writer.WritePropertyName("LoadBalancerAttributes");
                context.Writer.WriteStartObject();

                var marshaller = AwsElbLoadBalancerAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.LoadBalancerAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLoadBalancerName())
            {
                context.Writer.WritePropertyName("LoadBalancerName");
                context.Writer.WriteStringValue(requestObject.LoadBalancerName);
            }

            if(requestObject.IsSetPolicies())
            {
                context.Writer.WritePropertyName("Policies");
                context.Writer.WriteStartObject();

                var marshaller = AwsElbLoadBalancerPoliciesMarshaller.Instance;
                marshaller.Marshall(requestObject.Policies, context);

                context.Writer.WriteEndObject();
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

            if(requestObject.IsSetSourceSecurityGroup())
            {
                context.Writer.WritePropertyName("SourceSecurityGroup");
                context.Writer.WriteStartObject();

                var marshaller = AwsElbLoadBalancerSourceSecurityGroupMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceSecurityGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSubnets())
            {
                context.Writer.WritePropertyName("Subnets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSubnetsListValue in requestObject.Subnets)
                {
                        context.Writer.WriteStringValue(requestObjectSubnetsListValue);
                }
                context.Writer.WriteEndArray();
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
        public readonly static AwsElbLoadBalancerDetailsMarshaller Instance = new AwsElbLoadBalancerDetailsMarshaller();

    }
}