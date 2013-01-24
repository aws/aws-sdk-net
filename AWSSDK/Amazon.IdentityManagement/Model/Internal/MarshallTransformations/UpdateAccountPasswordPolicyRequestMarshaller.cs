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
    /// Update Account Password Policy Request Marshaller
    /// </summary>       
    public class UpdateAccountPasswordPolicyRequestMarshaller : IMarshaller<IRequest, UpdateAccountPasswordPolicyRequest>
    {
        public IRequest Marshall(UpdateAccountPasswordPolicyRequest updateAccountPasswordPolicyRequest)
        {
            IRequest request = new DefaultRequest(updateAccountPasswordPolicyRequest, "AmazonIdentityManagementService");
            request.Parameters.Add("Action", "UpdateAccountPasswordPolicy");
            request.Parameters.Add("Version", "2010-05-08");
            if (updateAccountPasswordPolicyRequest != null && updateAccountPasswordPolicyRequest.IsSetMinimumPasswordLength())
            {
                request.Parameters.Add("MinimumPasswordLength", StringUtils.FromInt(updateAccountPasswordPolicyRequest.MinimumPasswordLength));
            }
            if (updateAccountPasswordPolicyRequest != null && updateAccountPasswordPolicyRequest.IsSetRequireSymbols())
            {
                request.Parameters.Add("RequireSymbols", StringUtils.FromBool(updateAccountPasswordPolicyRequest.RequireSymbols));
            }
            if (updateAccountPasswordPolicyRequest != null && updateAccountPasswordPolicyRequest.IsSetRequireNumbers())
            {
                request.Parameters.Add("RequireNumbers", StringUtils.FromBool(updateAccountPasswordPolicyRequest.RequireNumbers));
            }
            if (updateAccountPasswordPolicyRequest != null && updateAccountPasswordPolicyRequest.IsSetRequireUppercaseCharacters())
            {
                request.Parameters.Add("RequireUppercaseCharacters", StringUtils.FromBool(updateAccountPasswordPolicyRequest.RequireUppercaseCharacters));
            }
            if (updateAccountPasswordPolicyRequest != null && updateAccountPasswordPolicyRequest.IsSetRequireLowercaseCharacters())
            {
                request.Parameters.Add("RequireLowercaseCharacters", StringUtils.FromBool(updateAccountPasswordPolicyRequest.RequireLowercaseCharacters));
            }
            if (updateAccountPasswordPolicyRequest != null && updateAccountPasswordPolicyRequest.IsSetAllowUsersToChangePassword())
            {
                request.Parameters.Add("AllowUsersToChangePassword", StringUtils.FromBool(updateAccountPasswordPolicyRequest.AllowUsersToChangePassword));
            }

            return request;
        }
    }
}
