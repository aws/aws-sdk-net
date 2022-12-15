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
    /// AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails Marshaller
    /// </summary>
    public class AwsEc2LaunchTemplateDataNetworkInterfaceSetDetailsMarshaller : IRequestMarshaller<AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAssociateCarrierIpAddress())
            {
                context.Writer.WritePropertyName("AssociateCarrierIpAddress");
                context.Writer.Write(requestObject.AssociateCarrierIpAddress);
            }

            if(requestObject.IsSetAssociatePublicIpAddress())
            {
                context.Writer.WritePropertyName("AssociatePublicIpAddress");
                context.Writer.Write(requestObject.AssociatePublicIpAddress);
            }

            if(requestObject.IsSetDeleteOnTermination())
            {
                context.Writer.WritePropertyName("DeleteOnTermination");
                context.Writer.Write(requestObject.DeleteOnTermination);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetDeviceIndex())
            {
                context.Writer.WritePropertyName("DeviceIndex");
                context.Writer.Write(requestObject.DeviceIndex);
            }

            if(requestObject.IsSetGroups())
            {
                context.Writer.WritePropertyName("Groups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectGroupsListValue in requestObject.Groups)
                {
                        context.Writer.Write(requestObjectGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInterfaceType())
            {
                context.Writer.WritePropertyName("InterfaceType");
                context.Writer.Write(requestObject.InterfaceType);
            }

            if(requestObject.IsSetIpv4PrefixCount())
            {
                context.Writer.WritePropertyName("Ipv4PrefixCount");
                context.Writer.Write(requestObject.Ipv4PrefixCount);
            }

            if(requestObject.IsSetIpv4Prefixes())
            {
                context.Writer.WritePropertyName("Ipv4Prefixes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIpv4PrefixesListValue in requestObject.Ipv4Prefixes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv4PrefixesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv4PrefixesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIpv6AddressCount())
            {
                context.Writer.WritePropertyName("Ipv6AddressCount");
                context.Writer.Write(requestObject.Ipv6AddressCount);
            }

            if(requestObject.IsSetIpv6Addresses())
            {
                context.Writer.WritePropertyName("Ipv6Addresses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIpv6AddressesListValue in requestObject.Ipv6Addresses)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6AddressesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIpv6PrefixCount())
            {
                context.Writer.WritePropertyName("Ipv6PrefixCount");
                context.Writer.Write(requestObject.Ipv6PrefixCount);
            }

            if(requestObject.IsSetIpv6Prefixes())
            {
                context.Writer.WritePropertyName("Ipv6Prefixes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIpv6PrefixesListValue in requestObject.Ipv6Prefixes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6PrefixesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6PrefixesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkCardIndex())
            {
                context.Writer.WritePropertyName("NetworkCardIndex");
                context.Writer.Write(requestObject.NetworkCardIndex);
            }

            if(requestObject.IsSetNetworkInterfaceId())
            {
                context.Writer.WritePropertyName("NetworkInterfaceId");
                context.Writer.Write(requestObject.NetworkInterfaceId);
            }

            if(requestObject.IsSetPrivateIpAddress())
            {
                context.Writer.WritePropertyName("PrivateIpAddress");
                context.Writer.Write(requestObject.PrivateIpAddress);
            }

            if(requestObject.IsSetPrivateIpAddresses())
            {
                context.Writer.WritePropertyName("PrivateIpAddresses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPrivateIpAddressesListValue in requestObject.PrivateIpAddresses)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2LaunchTemplateDataNetworkInterfaceSetPrivateIpAddressesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectPrivateIpAddressesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSecondaryPrivateIpAddressCount())
            {
                context.Writer.WritePropertyName("SecondaryPrivateIpAddressCount");
                context.Writer.Write(requestObject.SecondaryPrivateIpAddressCount);
            }

            if(requestObject.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.Write(requestObject.SubnetId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2LaunchTemplateDataNetworkInterfaceSetDetailsMarshaller Instance = new AwsEc2LaunchTemplateDataNetworkInterfaceSetDetailsMarshaller();

    }
}