/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.IdentityManagement.Model.Transform
{
    /// <summary>
    /// List Virtual M F A Devices Request Marshaller
    /// </summary>       
    public class ListVirtualMFADevicesRequestMarshaller : IMarshaller<IRequest<ListVirtualMFADevicesRequest>, ListVirtualMFADevicesRequest>
    {
        public IRequest<ListVirtualMFADevicesRequest> Marshall(ListVirtualMFADevicesRequest listVirtualMFADevicesRequest)
        {
            IRequest<ListVirtualMFADevicesRequest> request = new DefaultRequest<ListVirtualMFADevicesRequest>(listVirtualMFADevicesRequest, "AmazonIdentityManagementService");
            request.Parameters.Add("Action", "ListVirtualMFADevices");
            request.Parameters.Add("Version", "2010-05-08");
            if (listVirtualMFADevicesRequest != null && listVirtualMFADevicesRequest.IsSetAssignmentStatus())
            {
                request.Parameters.Add("AssignmentStatus", StringUtils.FromString(listVirtualMFADevicesRequest.AssignmentStatus));
            }
            if (listVirtualMFADevicesRequest != null && listVirtualMFADevicesRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(listVirtualMFADevicesRequest.Marker));
            }
            if (listVirtualMFADevicesRequest != null && listVirtualMFADevicesRequest.IsSetMaxItems())
            {
                request.Parameters.Add("MaxItems", StringUtils.FromInt(listVirtualMFADevicesRequest.MaxItems));
            }

            return request;
        }
    }
}
