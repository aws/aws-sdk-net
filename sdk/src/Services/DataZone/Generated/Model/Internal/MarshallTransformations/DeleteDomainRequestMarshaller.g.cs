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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.DataZone.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteDomain Request Marshaller
    /// </summary>
    public partial class DeleteDomainRequestMarshaller : IMarshaller<IRequest, DeleteDomainRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteDomainRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteDomainRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "DELETE";

            if (publicRequest.IsSetCascadeDelete())
            {
                request.Parameters.Add("cascadeDelete", StringUtils.FromBool(publicRequest.CascadeDelete.Value));
            }

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("clientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("clientToken", Guid.NewGuid().ToString());
            }

            if (publicRequest.IsSetSkipDeletionCheck())
            {
                request.Parameters.Add("skipDeletionCheck", StringUtils.FromBool(publicRequest.SkipDeletionCheck.Value));
            }

            if (!publicRequest.IsSetIdentifier())
            {
                throw new AmazonDataZoneException("Request object does not have required field Identifier set");
            }
            request.AddPathResource("{identifier}", StringUtils.FromString(publicRequest.Identifier));

            request.ResourcePath = "/v2/domains/{identifier}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DeleteDomainRequestMarshaller _instance = new();

        internal static DeleteDomainRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteDomainRequestMarshaller Instance => _instance;
    }
}
