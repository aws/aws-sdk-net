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
    /// AwsEc2EipDetails Marshaller
    /// </summary>
    public class AwsEc2EipDetailsMarshaller : IRequestMarshaller<AwsEc2EipDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2EipDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllocationId())
            {
                context.Writer.WritePropertyName("AllocationId");
                context.Writer.WriteStringValue(requestObject.AllocationId);
            }

            if(requestObject.IsSetAssociationId())
            {
                context.Writer.WritePropertyName("AssociationId");
                context.Writer.WriteStringValue(requestObject.AssociationId);
            }

            if(requestObject.IsSetDomain())
            {
                context.Writer.WritePropertyName("Domain");
                context.Writer.WriteStringValue(requestObject.Domain);
            }

            if(requestObject.IsSetInstanceId())
            {
                context.Writer.WritePropertyName("InstanceId");
                context.Writer.WriteStringValue(requestObject.InstanceId);
            }

            if(requestObject.IsSetNetworkBorderGroup())
            {
                context.Writer.WritePropertyName("NetworkBorderGroup");
                context.Writer.WriteStringValue(requestObject.NetworkBorderGroup);
            }

            if(requestObject.IsSetNetworkInterfaceId())
            {
                context.Writer.WritePropertyName("NetworkInterfaceId");
                context.Writer.WriteStringValue(requestObject.NetworkInterfaceId);
            }

            if(requestObject.IsSetNetworkInterfaceOwnerId())
            {
                context.Writer.WritePropertyName("NetworkInterfaceOwnerId");
                context.Writer.WriteStringValue(requestObject.NetworkInterfaceOwnerId);
            }

            if(requestObject.IsSetPrivateIpAddress())
            {
                context.Writer.WritePropertyName("PrivateIpAddress");
                context.Writer.WriteStringValue(requestObject.PrivateIpAddress);
            }

            if(requestObject.IsSetPublicIp())
            {
                context.Writer.WritePropertyName("PublicIp");
                context.Writer.WriteStringValue(requestObject.PublicIp);
            }

            if(requestObject.IsSetPublicIpv4Pool())
            {
                context.Writer.WritePropertyName("PublicIpv4Pool");
                context.Writer.WriteStringValue(requestObject.PublicIpv4Pool);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2EipDetailsMarshaller Instance = new AwsEc2EipDetailsMarshaller();

    }
}