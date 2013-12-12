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
    /// Associate Address Request Marshaller
    /// </summary>       
    public class AssociateAddressRequestMarshaller : IMarshaller<IRequest, AssociateAddressRequest>
    {
        public IRequest Marshall(AssociateAddressRequest associateAddressRequest)
        {
            IRequest request = new DefaultRequest(associateAddressRequest, "AmazonEC2");
            request.Parameters.Add("Action", "AssociateAddress");
            request.Parameters.Add("Version", "2013-10-15");
            if (associateAddressRequest != null && associateAddressRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(associateAddressRequest.InstanceId));
            }
            if (associateAddressRequest != null && associateAddressRequest.IsSetPublicIp())
            {
                request.Parameters.Add("PublicIp", StringUtils.FromString(associateAddressRequest.PublicIp));
            }
            if (associateAddressRequest != null && associateAddressRequest.IsSetAllocationId())
            {
                request.Parameters.Add("AllocationId", StringUtils.FromString(associateAddressRequest.AllocationId));
            }
            if (associateAddressRequest != null && associateAddressRequest.IsSetNetworkInterfaceId())
            {
                request.Parameters.Add("NetworkInterfaceId", StringUtils.FromString(associateAddressRequest.NetworkInterfaceId));
            }
            if (associateAddressRequest != null && associateAddressRequest.IsSetPrivateIpAddress())
            {
                request.Parameters.Add("PrivateIpAddress", StringUtils.FromString(associateAddressRequest.PrivateIpAddress));
            }
            if (associateAddressRequest != null && associateAddressRequest.IsSetAllowReassociation())
            {
                request.Parameters.Add("AllowReassociation", StringUtils.FromBool(associateAddressRequest.AllowReassociation));
            }

            return request;
        }
    }
}
