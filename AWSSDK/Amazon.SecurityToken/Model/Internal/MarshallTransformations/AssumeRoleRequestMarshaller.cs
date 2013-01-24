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
    /// Assume Role Request Marshaller
    /// </summary>       
    public class AssumeRoleRequestMarshaller : IMarshaller<IRequest, AssumeRoleRequest>
    {
        public IRequest Marshall(AssumeRoleRequest assumeRoleRequest)
        {
            IRequest request = new DefaultRequest(assumeRoleRequest, "AmazonSecurityTokenService");
            request.Parameters.Add("Action", "AssumeRole");
            request.Parameters.Add("Version", "2011-06-15");
            if (assumeRoleRequest != null && assumeRoleRequest.IsSetRoleArn())
            {
                request.Parameters.Add("RoleArn", StringUtils.FromString(assumeRoleRequest.RoleArn));
            }
            if (assumeRoleRequest != null && assumeRoleRequest.IsSetRoleSessionName())
            {
                request.Parameters.Add("RoleSessionName", StringUtils.FromString(assumeRoleRequest.RoleSessionName));
            }
            if (assumeRoleRequest != null && assumeRoleRequest.IsSetPolicy())
            {
                request.Parameters.Add("Policy", StringUtils.FromString(assumeRoleRequest.Policy));
            }
            if (assumeRoleRequest != null && assumeRoleRequest.IsSetDurationSeconds())
            {
                request.Parameters.Add("DurationSeconds", StringUtils.FromInt(assumeRoleRequest.DurationSeconds));
            }
            if (assumeRoleRequest != null && assumeRoleRequest.IsSetExternalId())
            {
                request.Parameters.Add("ExternalId", StringUtils.FromString(assumeRoleRequest.ExternalId));
            }

            return request;
        }
    }
}
