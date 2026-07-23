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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkspacesInstances.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkspacesInstances.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceNetworkInterfaceSpecification Marshaller
    /// </summary>
    public class InstanceNetworkInterfaceSpecificationMarshaller : IRequestMarshaller<InstanceNetworkInterfaceSpecification, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceNetworkInterfaceSpecification requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAssociateCarrierIpAddress())
            {
                context.Writer.WriteTextString("AssociateCarrierIpAddress");
                context.Writer.WriteBoolean(requestObject.AssociateCarrierIpAddress.Value);
            }
            if (requestObject.IsSetAssociatePublicIpAddress())
            {
                context.Writer.WriteTextString("AssociatePublicIpAddress");
                context.Writer.WriteBoolean(requestObject.AssociatePublicIpAddress.Value);
            }
            if (requestObject.IsSetConnectionTrackingSpecification())
            {
                context.Writer.WriteTextString("ConnectionTrackingSpecification");
                context.Writer.WriteStartMap(null);

                var marshaller = ConnectionTrackingSpecificationRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectionTrackingSpecification, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetDescription())
            {
                context.Writer.WriteTextString("Description");
                context.Writer.WriteTextString(requestObject.Description);
            }
            if (requestObject.IsSetDeviceIndex())
            {
                context.Writer.WriteTextString("DeviceIndex");
                context.Writer.WriteInt32(requestObject.DeviceIndex.Value);
            }
            if (requestObject.IsSetEnaSrdSpecification())
            {
                context.Writer.WriteTextString("EnaSrdSpecification");
                context.Writer.WriteStartMap(null);

                var marshaller = EnaSrdSpecificationRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.EnaSrdSpecification, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetGroups())
            {
                context.Writer.WriteTextString("Groups");
                context.Writer.WriteStartArray(requestObject.Groups.Count);
                foreach(var requestObjectGroupsListValue in requestObject.Groups)
                {
                        context.Writer.WriteTextString(requestObjectGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetInterfaceType())
            {
                context.Writer.WriteTextString("InterfaceType");
                context.Writer.WriteTextString(requestObject.InterfaceType);
            }
            if (requestObject.IsSetIpv4PrefixCount())
            {
                context.Writer.WriteTextString("Ipv4PrefixCount");
                context.Writer.WriteInt32(requestObject.Ipv4PrefixCount.Value);
            }
            if (requestObject.IsSetIpv4Prefixes())
            {
                context.Writer.WriteTextString("Ipv4Prefixes");
                context.Writer.WriteStartArray(requestObject.Ipv4Prefixes.Count);
                foreach(var requestObjectIpv4PrefixesListValue in requestObject.Ipv4Prefixes)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = Ipv4PrefixSpecificationRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv4PrefixesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetIpv6AddressCount())
            {
                context.Writer.WriteTextString("Ipv6AddressCount");
                context.Writer.WriteInt32(requestObject.Ipv6AddressCount.Value);
            }
            if (requestObject.IsSetIpv6Addresses())
            {
                context.Writer.WriteTextString("Ipv6Addresses");
                context.Writer.WriteStartArray(requestObject.Ipv6Addresses.Count);
                foreach(var requestObjectIpv6AddressesListValue in requestObject.Ipv6Addresses)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = InstanceIpv6AddressMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6AddressesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetIpv6PrefixCount())
            {
                context.Writer.WriteTextString("Ipv6PrefixCount");
                context.Writer.WriteInt32(requestObject.Ipv6PrefixCount.Value);
            }
            if (requestObject.IsSetIpv6Prefixes())
            {
                context.Writer.WriteTextString("Ipv6Prefixes");
                context.Writer.WriteStartArray(requestObject.Ipv6Prefixes.Count);
                foreach(var requestObjectIpv6PrefixesListValue in requestObject.Ipv6Prefixes)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = Ipv6PrefixSpecificationRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6PrefixesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetNetworkCardIndex())
            {
                context.Writer.WriteTextString("NetworkCardIndex");
                context.Writer.WriteInt32(requestObject.NetworkCardIndex.Value);
            }
            if (requestObject.IsSetNetworkInterfaceId())
            {
                context.Writer.WriteTextString("NetworkInterfaceId");
                context.Writer.WriteTextString(requestObject.NetworkInterfaceId);
            }
            if (requestObject.IsSetPrimaryIpv6())
            {
                context.Writer.WriteTextString("PrimaryIpv6");
                context.Writer.WriteBoolean(requestObject.PrimaryIpv6.Value);
            }
            if (requestObject.IsSetPrivateIpAddress())
            {
                context.Writer.WriteTextString("PrivateIpAddress");
                context.Writer.WriteTextString(requestObject.PrivateIpAddress);
            }
            if (requestObject.IsSetPrivateIpAddresses())
            {
                context.Writer.WriteTextString("PrivateIpAddresses");
                context.Writer.WriteStartArray(requestObject.PrivateIpAddresses.Count);
                foreach(var requestObjectPrivateIpAddressesListValue in requestObject.PrivateIpAddresses)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = PrivateIpAddressSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectPrivateIpAddressesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetSecondaryPrivateIpAddressCount())
            {
                context.Writer.WriteTextString("SecondaryPrivateIpAddressCount");
                context.Writer.WriteInt32(requestObject.SecondaryPrivateIpAddressCount.Value);
            }
            if (requestObject.IsSetSubnetId())
            {
                context.Writer.WriteTextString("SubnetId");
                context.Writer.WriteTextString(requestObject.SubnetId);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceNetworkInterfaceSpecificationMarshaller Instance = new InstanceNetworkInterfaceSpecificationMarshaller();

    }
}