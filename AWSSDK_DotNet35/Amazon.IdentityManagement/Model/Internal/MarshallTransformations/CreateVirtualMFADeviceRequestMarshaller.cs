/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateVirtualMFADevice Request Marshaller
    /// </summary>       
    public class CreateVirtualMFADeviceRequestMarshaller : IMarshaller<IRequest, CreateVirtualMFADeviceRequest>
    {
        public IRequest Marshall(CreateVirtualMFADeviceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.Parameters.Add("Action", "CreateVirtualMFADevice");
            request.Parameters.Add("Version", "2010-05-08");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetPath())
                {
                    request.Parameters.Add("Path", StringUtils.FromString(publicRequest.Path));
                }
                if(publicRequest.IsSetVirtualMFADeviceName())
                {
                    request.Parameters.Add("VirtualMFADeviceName", StringUtils.FromString(publicRequest.VirtualMFADeviceName));
                }
            }
            return request;
        }
    }
}