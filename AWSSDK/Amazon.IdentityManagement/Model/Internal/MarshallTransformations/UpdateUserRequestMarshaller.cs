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
    /// Update User Request Marshaller
    /// </summary>       
    public class UpdateUserRequestMarshaller : IMarshaller<IRequest, UpdateUserRequest>
    {
        public IRequest Marshall(UpdateUserRequest updateUserRequest)
        {
            IRequest request = new DefaultRequest(updateUserRequest, "AmazonIdentityManagementService");
            request.Parameters.Add("Action", "UpdateUser");
            request.Parameters.Add("Version", "2010-05-08");
            if (updateUserRequest != null && updateUserRequest.IsSetUserName())
            {
                request.Parameters.Add("UserName", StringUtils.FromString(updateUserRequest.UserName));
            }
            if (updateUserRequest != null && updateUserRequest.IsSetNewPath())
            {
                request.Parameters.Add("NewPath", StringUtils.FromString(updateUserRequest.NewPath));
            }
            if (updateUserRequest != null && updateUserRequest.IsSetNewUserName())
            {
                request.Parameters.Add("NewUserName", StringUtils.FromString(updateUserRequest.NewUserName));
            }

            return request;
        }
    }
}
