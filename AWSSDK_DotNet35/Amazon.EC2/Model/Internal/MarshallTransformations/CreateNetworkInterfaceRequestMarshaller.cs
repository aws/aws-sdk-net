/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Network Interface Request Marshaller
    /// </summary>       
    public class CreateNetworkInterfaceRequestMarshaller : IMarshaller<IRequest, CreateNetworkInterfaceRequest>
    {
        public IRequest Marshall(CreateNetworkInterfaceRequest createNetworkInterfaceRequest)
        {
            IRequest request = new DefaultRequest(createNetworkInterfaceRequest, "AmazonEC2");
            request.Parameters.Add("Action", "CreateNetworkInterface");
            request.Parameters.Add("Version", "2013-10-15");
            if (createNetworkInterfaceRequest != null && createNetworkInterfaceRequest.IsSetSubnetId())
            {
                request.Parameters.Add("SubnetId", StringUtils.FromString(createNetworkInterfaceRequest.SubnetId));
            }
            if (createNetworkInterfaceRequest != null && createNetworkInterfaceRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(createNetworkInterfaceRequest.Description));
            }
            if (createNetworkInterfaceRequest != null && createNetworkInterfaceRequest.IsSetPrivateIpAddress())
            {
                request.Parameters.Add("PrivateIpAddress", StringUtils.FromString(createNetworkInterfaceRequest.PrivateIpAddress));
            }
            if (createNetworkInterfaceRequest != null)
            {
                List<string> groupsList = createNetworkInterfaceRequest.Groups;

                int groupsListIndex = 1;
                foreach (string groupsListValue in groupsList)
                { 
                    request.Parameters.Add("SecurityGroupId." + groupsListIndex, StringUtils.FromString(groupsListValue));
                    groupsListIndex++;
                }
            }

            if (createNetworkInterfaceRequest != null)
            {
                List<PrivateIpAddressSpecification> privateIpAddressesList = createNetworkInterfaceRequest.PrivateIpAddresses;
                int privateIpAddressesListIndex = 1;
                foreach (PrivateIpAddressSpecification privateIpAddressesListValue in privateIpAddressesList)
                {
                    if (privateIpAddressesListValue != null && privateIpAddressesListValue.IsSetPrivateIpAddress())
                    {
                        request.Parameters.Add("PrivateIpAddresses." + privateIpAddressesListIndex + ".PrivateIpAddress", StringUtils.FromString(privateIpAddressesListValue.PrivateIpAddress));
                    }
                    if (privateIpAddressesListValue != null && privateIpAddressesListValue.IsSetPrimary())
                    {
                        request.Parameters.Add("PrivateIpAddresses." + privateIpAddressesListIndex + ".Primary", StringUtils.FromBool(privateIpAddressesListValue.Primary));
                    }

                    privateIpAddressesListIndex++;
                }
            }
            if (createNetworkInterfaceRequest != null && createNetworkInterfaceRequest.IsSetSecondaryPrivateIpAddressCount())
            {
                request.Parameters.Add("SecondaryPrivateIpAddressCount", StringUtils.FromInt(createNetworkInterfaceRequest.SecondaryPrivateIpAddressCount));
            }

            return request;
        }
    }
}
