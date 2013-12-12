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
    /// Attach Network Interface Request Marshaller
    /// </summary>       
    public class AttachNetworkInterfaceRequestMarshaller : IMarshaller<IRequest, AttachNetworkInterfaceRequest>
    {
        public IRequest Marshall(AttachNetworkInterfaceRequest attachNetworkInterfaceRequest)
        {
            IRequest request = new DefaultRequest(attachNetworkInterfaceRequest, "AmazonEC2");
            request.Parameters.Add("Action", "AttachNetworkInterface");
            request.Parameters.Add("Version", "2013-10-15");
            if (attachNetworkInterfaceRequest != null && attachNetworkInterfaceRequest.IsSetNetworkInterfaceId())
            {
                request.Parameters.Add("NetworkInterfaceId", StringUtils.FromString(attachNetworkInterfaceRequest.NetworkInterfaceId));
            }
            if (attachNetworkInterfaceRequest != null && attachNetworkInterfaceRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(attachNetworkInterfaceRequest.InstanceId));
            }
            if (attachNetworkInterfaceRequest != null && attachNetworkInterfaceRequest.IsSetDeviceIndex())
            {
                request.Parameters.Add("DeviceIndex", StringUtils.FromInt(attachNetworkInterfaceRequest.DeviceIndex));
            }

            return request;
        }
    }
}
