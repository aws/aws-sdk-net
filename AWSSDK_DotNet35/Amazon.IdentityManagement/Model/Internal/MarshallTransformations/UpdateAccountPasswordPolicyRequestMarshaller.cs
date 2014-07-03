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
    /// UpdateAccountPasswordPolicy Request Marshaller
    /// </summary>       
    public class UpdateAccountPasswordPolicyRequestMarshaller : IMarshaller<IRequest, UpdateAccountPasswordPolicyRequest>
    {
        public IRequest Marshall(UpdateAccountPasswordPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.Parameters.Add("Action", "UpdateAccountPasswordPolicy");
            request.Parameters.Add("Version", "2010-05-08");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAllowUsersToChangePassword())
                {
                    request.Parameters.Add("AllowUsersToChangePassword", StringUtils.FromBool(publicRequest.AllowUsersToChangePassword));
                }
                if(publicRequest.IsSetMinimumPasswordLength())
                {
                    request.Parameters.Add("MinimumPasswordLength", StringUtils.FromInt(publicRequest.MinimumPasswordLength));
                }
                if(publicRequest.IsSetRequireLowercaseCharacters())
                {
                    request.Parameters.Add("RequireLowercaseCharacters", StringUtils.FromBool(publicRequest.RequireLowercaseCharacters));
                }
                if(publicRequest.IsSetRequireNumbers())
                {
                    request.Parameters.Add("RequireNumbers", StringUtils.FromBool(publicRequest.RequireNumbers));
                }
                if(publicRequest.IsSetRequireSymbols())
                {
                    request.Parameters.Add("RequireSymbols", StringUtils.FromBool(publicRequest.RequireSymbols));
                }
                if(publicRequest.IsSetRequireUppercaseCharacters())
                {
                    request.Parameters.Add("RequireUppercaseCharacters", StringUtils.FromBool(publicRequest.RequireUppercaseCharacters));
                }
            }
            return request;
        }
    }
}