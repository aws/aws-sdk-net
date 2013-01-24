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
    /// Put User Policy Request Marshaller
    /// </summary>       
    public class PutUserPolicyRequestMarshaller : IMarshaller<IRequest, PutUserPolicyRequest>
    {
        public IRequest Marshall(PutUserPolicyRequest putUserPolicyRequest)
        {
            IRequest request = new DefaultRequest(putUserPolicyRequest, "AmazonIdentityManagementService");
            request.Parameters.Add("Action", "PutUserPolicy");
            request.Parameters.Add("Version", "2010-05-08");
            if (putUserPolicyRequest != null && putUserPolicyRequest.IsSetUserName())
            {
                request.Parameters.Add("UserName", StringUtils.FromString(putUserPolicyRequest.UserName));
            }
            if (putUserPolicyRequest != null && putUserPolicyRequest.IsSetPolicyName())
            {
                request.Parameters.Add("PolicyName", StringUtils.FromString(putUserPolicyRequest.PolicyName));
            }
            if (putUserPolicyRequest != null && putUserPolicyRequest.IsSetPolicyDocument())
            {
                request.Parameters.Add("PolicyDocument", StringUtils.FromString(putUserPolicyRequest.PolicyDocument));
            }

            return request;
        }
    }
}
