/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.IdentityManagement.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAccountPasswordPolicy Request Marshaller
    /// </summary>
    public partial class UpdateAccountPasswordPolicyRequestMarshaller : IMarshaller<IRequest, UpdateAccountPasswordPolicyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAccountPasswordPolicyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateAccountPasswordPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "UpdateAccountPasswordPolicy");
            request.Parameters.Add("Version", "2010-05-08");

            if (publicRequest.IsSetAllowUsersToChangePassword())
            {
                request.Parameters.Add("AllowUsersToChangePassword", StringUtils.FromBool(publicRequest.AllowUsersToChangePassword.Value));
            }
            if (publicRequest.IsSetHardExpiry())
            {
                request.Parameters.Add("HardExpiry", StringUtils.FromBool(publicRequest.HardExpiry.Value));
            }
            if (publicRequest.IsSetMaxPasswordAge())
            {
                request.Parameters.Add("MaxPasswordAge", StringUtils.FromInt(publicRequest.MaxPasswordAge.Value));
            }
            if (publicRequest.IsSetMinimumPasswordLength())
            {
                request.Parameters.Add("MinimumPasswordLength", StringUtils.FromInt(publicRequest.MinimumPasswordLength.Value));
            }
            if (publicRequest.IsSetPasswordReusePrevention())
            {
                request.Parameters.Add("PasswordReusePrevention", StringUtils.FromInt(publicRequest.PasswordReusePrevention.Value));
            }
            if (publicRequest.IsSetRequireLowercaseCharacters())
            {
                request.Parameters.Add("RequireLowercaseCharacters", StringUtils.FromBool(publicRequest.RequireLowercaseCharacters.Value));
            }
            if (publicRequest.IsSetRequireNumbers())
            {
                request.Parameters.Add("RequireNumbers", StringUtils.FromBool(publicRequest.RequireNumbers.Value));
            }
            if (publicRequest.IsSetRequireSymbols())
            {
                request.Parameters.Add("RequireSymbols", StringUtils.FromBool(publicRequest.RequireSymbols.Value));
            }
            if (publicRequest.IsSetRequireUppercaseCharacters())
            {
                request.Parameters.Add("RequireUppercaseCharacters", StringUtils.FromBool(publicRequest.RequireUppercaseCharacters.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly UpdateAccountPasswordPolicyRequestMarshaller _instance = new();

        internal static UpdateAccountPasswordPolicyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateAccountPasswordPolicyRequestMarshaller Instance => _instance;
    }
}
