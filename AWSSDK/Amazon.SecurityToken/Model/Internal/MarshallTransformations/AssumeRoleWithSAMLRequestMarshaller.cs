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
    /// Assume Role With S A M L Request Marshaller
    /// </summary>       
    public class AssumeRoleWithSAMLRequestMarshaller : IMarshaller<IRequest, AssumeRoleWithSAMLRequest>
    {
        public IRequest Marshall(AssumeRoleWithSAMLRequest assumeRoleWithSAMLRequest)
        {
            IRequest request = new DefaultRequest(assumeRoleWithSAMLRequest, "AmazonSecurityTokenService");
            request.Parameters.Add("Action", "AssumeRoleWithSAML");
            request.Parameters.Add("Version", "2011-06-15");
            if (assumeRoleWithSAMLRequest != null && assumeRoleWithSAMLRequest.IsSetRoleArn())
            {
                request.Parameters.Add("RoleArn", StringUtils.FromString(assumeRoleWithSAMLRequest.RoleArn));
            }
            if (assumeRoleWithSAMLRequest != null && assumeRoleWithSAMLRequest.IsSetPrincipalArn())
            {
                request.Parameters.Add("PrincipalArn", StringUtils.FromString(assumeRoleWithSAMLRequest.PrincipalArn));
            }
            if (assumeRoleWithSAMLRequest != null && assumeRoleWithSAMLRequest.IsSetSAMLAssertion())
            {
                request.Parameters.Add("SAMLAssertion", StringUtils.FromString(assumeRoleWithSAMLRequest.SAMLAssertion));
            }
            if (assumeRoleWithSAMLRequest != null && assumeRoleWithSAMLRequest.IsSetPolicy())
            {
                request.Parameters.Add("Policy", StringUtils.FromString(assumeRoleWithSAMLRequest.Policy));
            }
            if (assumeRoleWithSAMLRequest != null && assumeRoleWithSAMLRequest.IsSetDurationSeconds())
            {
                request.Parameters.Add("DurationSeconds", StringUtils.FromInt(assumeRoleWithSAMLRequest.DurationSeconds));
            }

            return request;
        }
    }
}
