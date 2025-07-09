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
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkspacesInstances.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceNetworkInterfaceSpecification Marshaller
    /// </summary>
    public class InstanceNetworkInterfaceSpecificationMarshaller : IRequestMarshaller<InstanceNetworkInterfaceSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceNetworkInterfaceSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAssociateCarrierIpAddress())
            {
                context.Writer.WritePropertyName("AssociateCarrierIpAddress");
                context.Writer.WriteBooleanValue(requestObject.AssociateCarrierIpAddress.Value);
            }

            if(requestObject.IsSetAssociatePublicIpAddress())
            {
                context.Writer.WritePropertyName("AssociatePublicIpAddress");
                context.Writer.WriteBooleanValue(requestObject.AssociatePublicIpAddress.Value);
            }

            if(requestObject.IsSetConnectionTrackingSpecification())
            {
                context.Writer.WritePropertyName("ConnectionTrackingSpecification");
                context.Writer.WriteStartObject();

                var marshaller = ConnectionTrackingSpecificationRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectionTrackingSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetDeviceIndex())
            {
                context.Writer.WritePropertyName("DeviceIndex");
                context.Writer.WriteNumberValue(requestObject.DeviceIndex.Value);
            }

            if(requestObject.IsSetEnaSrdSpecification())
            {
                context.Writer.WritePropertyName("EnaSrdSpecification");
                context.Writer.WriteStartObject();

                var marshaller = EnaSrdSpecificationRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.EnaSrdSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGroups())
            {
                context.Writer.WritePropertyName("Groups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGroupsListValue in requestObject.Groups)
                {
                        context.Writer.WriteStringValue(requestObjectGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInterfaceType())
            {
                context.Writer.WritePropertyName("InterfaceType");
                context.Writer.WriteStringValue(requestObject.InterfaceType);
            }

            if(requestObject.IsSetIpv4PrefixCount())
            {
                context.Writer.WritePropertyName("Ipv4PrefixCount");
                context.Writer.WriteNumberValue(requestObject.Ipv4PrefixCount.Value);
            }

            if(requestObject.IsSetIpv4Prefixes())
            {
                context.Writer.WritePropertyName("Ipv4Prefixes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIpv4PrefixesListValue in requestObject.Ipv4Prefixes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = Ipv4PrefixSpecificationRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv4PrefixesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIpv6AddressCount())
            {
                context.Writer.WritePropertyName("Ipv6AddressCount");
                context.Writer.WriteNumberValue(requestObject.Ipv6AddressCount.Value);
            }

            if(requestObject.IsSetIpv6Addresses())
            {
                context.Writer.WritePropertyName("Ipv6Addresses");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIpv6AddressesListValue in requestObject.Ipv6Addresses)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InstanceIpv6AddressMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6AddressesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIpv6PrefixCount())
            {
                context.Writer.WritePropertyName("Ipv6PrefixCount");
                context.Writer.WriteNumberValue(requestObject.Ipv6PrefixCount.Value);
            }

            if(requestObject.IsSetIpv6Prefixes())
            {
                context.Writer.WritePropertyName("Ipv6Prefixes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIpv6PrefixesListValue in requestObject.Ipv6Prefixes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = Ipv6PrefixSpecificationRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6PrefixesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkCardIndex())
            {
                context.Writer.WritePropertyName("NetworkCardIndex");
                context.Writer.WriteNumberValue(requestObject.NetworkCardIndex.Value);
            }

            if(requestObject.IsSetNetworkInterfaceId())
            {
                context.Writer.WritePropertyName("NetworkInterfaceId");
                context.Writer.WriteStringValue(requestObject.NetworkInterfaceId);
            }

            if(requestObject.IsSetPrimaryIpv6())
            {
                context.Writer.WritePropertyName("PrimaryIpv6");
                context.Writer.WriteBooleanValue(requestObject.PrimaryIpv6.Value);
            }

            if(requestObject.IsSetPrivateIpAddress())
            {
                context.Writer.WritePropertyName("PrivateIpAddress");
                context.Writer.WriteStringValue(requestObject.PrivateIpAddress);
            }

            if(requestObject.IsSetPrivateIpAddresses())
            {
                context.Writer.WritePropertyName("PrivateIpAddresses");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPrivateIpAddressesListValue in requestObject.PrivateIpAddresses)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PrivateIpAddressSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectPrivateIpAddressesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecondaryPrivateIpAddressCount())
            {
                context.Writer.WritePropertyName("SecondaryPrivateIpAddressCount");
                context.Writer.WriteNumberValue(requestObject.SecondaryPrivateIpAddressCount.Value);
            }

            if(requestObject.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.WriteStringValue(requestObject.SubnetId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceNetworkInterfaceSpecificationMarshaller Instance = new InstanceNetworkInterfaceSpecificationMarshaller();

    }
}