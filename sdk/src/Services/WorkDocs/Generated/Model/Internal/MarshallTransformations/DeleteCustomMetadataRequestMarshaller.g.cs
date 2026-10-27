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

using Amazon.WorkDocs.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteCustomMetadata Request Marshaller
    /// </summary>
    public partial class DeleteCustomMetadataRequestMarshaller : IMarshaller<IRequest, DeleteCustomMetadataRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteCustomMetadataRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteCustomMetadataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";
            request.HttpMethod = "DELETE";

            if (publicRequest.IsSetDeleteAll())
            {
                request.Parameters.Add("deleteAll", StringUtils.FromBool(publicRequest.DeleteAll.Value));
            }

            if (publicRequest.IsSetKeys())
            {
                request.ParameterCollection.Add("keys", publicRequest.Keys);
            }

            if (publicRequest.IsSetVersionId())
            {
                request.Parameters.Add("versionId", StringUtils.FromString(publicRequest.VersionId));
            }

            if (publicRequest.IsSetAuthenticationToken())
            {
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;
            }

            if (!publicRequest.IsSetResourceId())
            {
                throw new AmazonWorkDocsException("Request object does not have required field ResourceId set");
            }
            request.AddPathResource("{ResourceId}", StringUtils.FromString(publicRequest.ResourceId));

            request.ResourcePath = "/api/v1/resources/{ResourceId}/customMetadata";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DeleteCustomMetadataRequestMarshaller _instance = new();

        internal static DeleteCustomMetadataRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteCustomMetadataRequestMarshaller Instance => _instance;
    }
}
