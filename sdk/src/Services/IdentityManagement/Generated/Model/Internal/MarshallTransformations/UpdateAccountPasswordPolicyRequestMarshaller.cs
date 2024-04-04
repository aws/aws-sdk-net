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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAccountPasswordPolicy Request Marshaller
    /// </summary>       
    public class UpdateAccountPasswordPolicyRequestMarshaller : IMarshaller<IRequest, UpdateAccountPasswordPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAccountPasswordPolicyRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
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
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetHardExpiry())
                {
                    request.Parameters.Add("HardExpiry", StringUtils.FromBool(publicRequest.HardExpiry));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMaxPasswordAge())
                {
                    request.Parameters.Add("MaxPasswordAge", StringUtils.FromInt(publicRequest.MaxPasswordAge));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMinimumPasswordLength())
                {
                    request.Parameters.Add("MinimumPasswordLength", StringUtils.FromInt(publicRequest.MinimumPasswordLength));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPasswordReusePrevention())
                {
                    request.Parameters.Add("PasswordReusePrevention", StringUtils.FromInt(publicRequest.PasswordReusePrevention));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRequireLowercaseCharacters())
                {
                    request.Parameters.Add("RequireLowercaseCharacters", StringUtils.FromBool(publicRequest.RequireLowercaseCharacters));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRequireNumbers())
                {
                    request.Parameters.Add("RequireNumbers", StringUtils.FromBool(publicRequest.RequireNumbers));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRequireSymbols())
                {
                    request.Parameters.Add("RequireSymbols", StringUtils.FromBool(publicRequest.RequireSymbols));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRequireUppercaseCharacters())
                {
                    request.Parameters.Add("RequireUppercaseCharacters", StringUtils.FromBool(publicRequest.RequireUppercaseCharacters));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static UpdateAccountPasswordPolicyRequestMarshaller _instance = new UpdateAccountPasswordPolicyRequestMarshaller();        

        internal static UpdateAccountPasswordPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAccountPasswordPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}