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
    /// AwsEc2SubnetDetails Marshaller
    /// </summary>
    public class AwsEc2SubnetDetailsMarshaller : IRequestMarshaller<AwsEc2SubnetDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2SubnetDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAssignIpv6AddressOnCreation())
            {
                context.Writer.WritePropertyName("AssignIpv6AddressOnCreation");
                context.Writer.WriteBooleanValue(requestObject.AssignIpv6AddressOnCreation.Value);
            }

            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.WriteStringValue(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetAvailabilityZoneId())
            {
                context.Writer.WritePropertyName("AvailabilityZoneId");
                context.Writer.WriteStringValue(requestObject.AvailabilityZoneId);
            }

            if(requestObject.IsSetAvailableIpAddressCount())
            {
                context.Writer.WritePropertyName("AvailableIpAddressCount");
                context.Writer.WriteNumberValue(requestObject.AvailableIpAddressCount.Value);
            }

            if(requestObject.IsSetCidrBlock())
            {
                context.Writer.WritePropertyName("CidrBlock");
                context.Writer.WriteStringValue(requestObject.CidrBlock);
            }

            if(requestObject.IsSetDefaultForAz())
            {
                context.Writer.WritePropertyName("DefaultForAz");
                context.Writer.WriteBooleanValue(requestObject.DefaultForAz.Value);
            }

            if(requestObject.IsSetIpv6CidrBlockAssociationSet())
            {
                context.Writer.WritePropertyName("Ipv6CidrBlockAssociationSet");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIpv6CidrBlockAssociationSetListValue in requestObject.Ipv6CidrBlockAssociationSet)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = Ipv6CidrBlockAssociationMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6CidrBlockAssociationSetListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMapPublicIpOnLaunch())
            {
                context.Writer.WritePropertyName("MapPublicIpOnLaunch");
                context.Writer.WriteBooleanValue(requestObject.MapPublicIpOnLaunch.Value);
            }

            if(requestObject.IsSetOwnerId())
            {
                context.Writer.WritePropertyName("OwnerId");
                context.Writer.WriteStringValue(requestObject.OwnerId);
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteStringValue(requestObject.State);
            }

            if(requestObject.IsSetSubnetArn())
            {
                context.Writer.WritePropertyName("SubnetArn");
                context.Writer.WriteStringValue(requestObject.SubnetArn);
            }

            if(requestObject.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.WriteStringValue(requestObject.SubnetId);
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
        public readonly static AwsEc2SubnetDetailsMarshaller Instance = new AwsEc2SubnetDetailsMarshaller();

    }
}