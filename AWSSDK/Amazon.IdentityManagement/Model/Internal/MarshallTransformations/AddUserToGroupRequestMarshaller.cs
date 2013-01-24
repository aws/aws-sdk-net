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
    /// Add User To Group Request Marshaller
    /// </summary>       
    public class AddUserToGroupRequestMarshaller : IMarshaller<IRequest, AddUserToGroupRequest>
    {
        public IRequest Marshall(AddUserToGroupRequest addUserToGroupRequest)
        {
            IRequest request = new DefaultRequest(addUserToGroupRequest, "AmazonIdentityManagementService");
            request.Parameters.Add("Action", "AddUserToGroup");
            request.Parameters.Add("Version", "2010-05-08");
            if (addUserToGroupRequest != null && addUserToGroupRequest.IsSetGroupName())
            {
                request.Parameters.Add("GroupName", StringUtils.FromString(addUserToGroupRequest.GroupName));
            }
            if (addUserToGroupRequest != null && addUserToGroupRequest.IsSetUserName())
            {
                request.Parameters.Add("UserName", StringUtils.FromString(addUserToGroupRequest.UserName));
            }

            return request;
        }
    }
}
