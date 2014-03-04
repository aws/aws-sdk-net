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
    /// Remove Role From Instance Profile Request Marshaller
    /// </summary>       
    public class RemoveRoleFromInstanceProfileRequestMarshaller : IMarshaller<IRequest, RemoveRoleFromInstanceProfileRequest>
    {
        public IRequest Marshall(RemoveRoleFromInstanceProfileRequest removeRoleFromInstanceProfileRequest)
        {
            IRequest request = new DefaultRequest(removeRoleFromInstanceProfileRequest, "AmazonIdentityManagementService");
            request.Parameters.Add("Action", "RemoveRoleFromInstanceProfile");
            request.Parameters.Add("Version", "2010-05-08");
            if (removeRoleFromInstanceProfileRequest != null && removeRoleFromInstanceProfileRequest.IsSetInstanceProfileName())
            {
                request.Parameters.Add("InstanceProfileName", StringUtils.FromString(removeRoleFromInstanceProfileRequest.InstanceProfileName));
            }
            if (removeRoleFromInstanceProfileRequest != null && removeRoleFromInstanceProfileRequest.IsSetRoleName())
            {
                request.Parameters.Add("RoleName", StringUtils.FromString(removeRoleFromInstanceProfileRequest.RoleName));
            }

            return request;
        }
    }
}
