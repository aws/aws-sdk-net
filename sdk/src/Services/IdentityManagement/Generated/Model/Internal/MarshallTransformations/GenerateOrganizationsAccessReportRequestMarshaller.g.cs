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
    /// GenerateOrganizationsAccessReport Request Marshaller
    /// </summary>
    public partial class GenerateOrganizationsAccessReportRequestMarshaller : IMarshaller<IRequest, GenerateOrganizationsAccessReportRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GenerateOrganizationsAccessReportRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GenerateOrganizationsAccessReportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "GenerateOrganizationsAccessReport");
            request.Parameters.Add("Version", "2010-05-08");

            if (publicRequest.IsSetEntityPath())
            {
                request.Parameters.Add("EntityPath", StringUtils.FromString(publicRequest.EntityPath));
            }
            if (publicRequest.IsSetOrganizationsPolicyId())
            {
                request.Parameters.Add("OrganizationsPolicyId", StringUtils.FromString(publicRequest.OrganizationsPolicyId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly GenerateOrganizationsAccessReportRequestMarshaller _instance = new();

        internal static GenerateOrganizationsAccessReportRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GenerateOrganizationsAccessReportRequestMarshaller Instance => _instance;
    }
}
