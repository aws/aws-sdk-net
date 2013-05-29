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

using Amazon.SecurityToken.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Assume Role With Web Identity Request Marshaller
    /// </summary>       
    public class AssumeRoleWithWebIdentityRequestMarshaller : IMarshaller<IRequest, AssumeRoleWithWebIdentityRequest>
    {
        public IRequest Marshall(AssumeRoleWithWebIdentityRequest assumeRoleWithWebIdentityRequest)
        {
            IRequest request = new DefaultRequest(assumeRoleWithWebIdentityRequest, "AmazonSecurityTokenService");
            request.Parameters.Add("Action", "AssumeRoleWithWebIdentity");
            request.Parameters.Add("Version", "2011-06-15");
            if (assumeRoleWithWebIdentityRequest != null && assumeRoleWithWebIdentityRequest.IsSetRoleArn())
            {
                request.Parameters.Add("RoleArn", StringUtils.FromString(assumeRoleWithWebIdentityRequest.RoleArn));
            }
            if (assumeRoleWithWebIdentityRequest != null && assumeRoleWithWebIdentityRequest.IsSetRoleSessionName())
            {
                request.Parameters.Add("RoleSessionName", StringUtils.FromString(assumeRoleWithWebIdentityRequest.RoleSessionName));
            }
            if (assumeRoleWithWebIdentityRequest != null && assumeRoleWithWebIdentityRequest.IsSetWebIdentityToken())
            {
                request.Parameters.Add("WebIdentityToken", StringUtils.FromString(assumeRoleWithWebIdentityRequest.WebIdentityToken));
            }
            if (assumeRoleWithWebIdentityRequest != null && assumeRoleWithWebIdentityRequest.IsSetProviderId())
            {
                request.Parameters.Add("ProviderId", StringUtils.FromString(assumeRoleWithWebIdentityRequest.ProviderId));
            }
            if (assumeRoleWithWebIdentityRequest != null && assumeRoleWithWebIdentityRequest.IsSetPolicy())
            {
                request.Parameters.Add("Policy", StringUtils.FromString(assumeRoleWithWebIdentityRequest.Policy));
            }
            if (assumeRoleWithWebIdentityRequest != null && assumeRoleWithWebIdentityRequest.IsSetDurationSeconds())
            {
                request.Parameters.Add("DurationSeconds", StringUtils.FromInt(assumeRoleWithWebIdentityRequest.DurationSeconds));
            }

            return request;
        }
    }
}
