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
    /// Enable M F A Device Request Marshaller
    /// </summary>       
    public class EnableMFADeviceRequestMarshaller : IMarshaller<IRequest, EnableMFADeviceRequest>
    {
        public IRequest Marshall(EnableMFADeviceRequest enableMFADeviceRequest)
        {
            IRequest request = new DefaultRequest(enableMFADeviceRequest, "AmazonIdentityManagementService");
            request.Parameters.Add("Action", "EnableMFADevice");
            request.Parameters.Add("Version", "2010-05-08");
            if (enableMFADeviceRequest != null && enableMFADeviceRequest.IsSetUserName())
            {
                request.Parameters.Add("UserName", StringUtils.FromString(enableMFADeviceRequest.UserName));
            }
            if (enableMFADeviceRequest != null && enableMFADeviceRequest.IsSetSerialNumber())
            {
                request.Parameters.Add("SerialNumber", StringUtils.FromString(enableMFADeviceRequest.SerialNumber));
            }
            if (enableMFADeviceRequest != null && enableMFADeviceRequest.IsSetAuthenticationCode1())
            {
                request.Parameters.Add("AuthenticationCode1", StringUtils.FromString(enableMFADeviceRequest.AuthenticationCode1));
            }
            if (enableMFADeviceRequest != null && enableMFADeviceRequest.IsSetAuthenticationCode2())
            {
                request.Parameters.Add("AuthenticationCode2", StringUtils.FromString(enableMFADeviceRequest.AuthenticationCode2));
            }

            return request;
        }
    }
}
