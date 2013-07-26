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

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Virtual M F A Device Request Marshaller
    /// </summary>       
    public class CreateVirtualMFADeviceRequestMarshaller : IMarshaller<IRequest, CreateVirtualMFADeviceRequest>
    {
        public IRequest Marshall(CreateVirtualMFADeviceRequest createVirtualMFADeviceRequest)
        {
            IRequest request = new DefaultRequest(createVirtualMFADeviceRequest, "AmazonIdentityManagementService");
            request.Parameters.Add("Action", "CreateVirtualMFADevice");
            request.Parameters.Add("Version", "2010-05-08");
            if (createVirtualMFADeviceRequest != null && createVirtualMFADeviceRequest.IsSetPath())
            {
                request.Parameters.Add("Path", StringUtils.FromString(createVirtualMFADeviceRequest.Path));
            }
            if (createVirtualMFADeviceRequest != null && createVirtualMFADeviceRequest.IsSetVirtualMFADeviceName())
            {
                request.Parameters.Add("VirtualMFADeviceName", StringUtils.FromString(createVirtualMFADeviceRequest.VirtualMFADeviceName));
            }

            return request;
        }
    }
}
