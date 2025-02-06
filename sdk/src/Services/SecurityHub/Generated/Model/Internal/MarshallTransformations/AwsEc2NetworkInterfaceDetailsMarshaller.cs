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
    /// AwsEc2NetworkInterfaceDetails Marshaller
    /// </summary>
    public class AwsEc2NetworkInterfaceDetailsMarshaller : IRequestMarshaller<AwsEc2NetworkInterfaceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2NetworkInterfaceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttachment())
            {
                context.Writer.WritePropertyName("Attachment");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2NetworkInterfaceAttachmentMarshaller.Instance;
                marshaller.Marshall(requestObject.Attachment, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIpV6Addresses())
            {
                context.Writer.WritePropertyName("IpV6Addresses");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIpV6AddressesListValue in requestObject.IpV6Addresses)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2NetworkInterfaceIpV6AddressDetailMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpV6AddressesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkInterfaceId())
            {
                context.Writer.WritePropertyName("NetworkInterfaceId");
                context.Writer.WriteStringValue(requestObject.NetworkInterfaceId);
            }

            if(requestObject.IsSetPrivateIpAddresses())
            {
                context.Writer.WritePropertyName("PrivateIpAddresses");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPrivateIpAddressesListValue in requestObject.PrivateIpAddresses)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2NetworkInterfacePrivateIpAddressDetailMarshaller.Instance;
                    marshaller.Marshall(requestObjectPrivateIpAddressesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPublicDnsName())
            {
                context.Writer.WritePropertyName("PublicDnsName");
                context.Writer.WriteStringValue(requestObject.PublicDnsName);
            }

            if(requestObject.IsSetPublicIp())
            {
                context.Writer.WritePropertyName("PublicIp");
                context.Writer.WriteStringValue(requestObject.PublicIp);
            }

            if(requestObject.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("SecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2NetworkInterfaceSecurityGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecurityGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSourceDestCheck())
            {
                context.Writer.WritePropertyName("SourceDestCheck");
                context.Writer.WriteBooleanValue(requestObject.SourceDestCheck.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2NetworkInterfaceDetailsMarshaller Instance = new AwsEc2NetworkInterfaceDetailsMarshaller();

    }
}