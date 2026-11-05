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
    /// CreateServiceLinkedRole Request Marshaller
    /// </summary>
    public partial class CreateServiceLinkedRoleRequestMarshaller : IMarshaller<IRequest, CreateServiceLinkedRoleRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateServiceLinkedRoleRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateServiceLinkedRoleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateServiceLinkedRole");
            request.Parameters.Add("Version", "2010-05-08");

            if (publicRequest.IsSetAWSServiceName())
            {
                request.Parameters.Add("AWSServiceName", StringUtils.FromString(publicRequest.AWSServiceName));
            }
            if (publicRequest.IsSetCustomSuffix())
            {
                request.Parameters.Add("CustomSuffix", StringUtils.FromString(publicRequest.CustomSuffix));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateServiceLinkedRoleRequestMarshaller _instance = new();

        internal static CreateServiceLinkedRoleRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateServiceLinkedRoleRequestMarshaller Instance => _instance;
    }
}
