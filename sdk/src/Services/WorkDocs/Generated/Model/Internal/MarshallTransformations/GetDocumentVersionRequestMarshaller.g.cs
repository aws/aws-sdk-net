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
    /// GetDocumentVersion Request Marshaller
    /// </summary>
    public partial class GetDocumentVersionRequestMarshaller : IMarshaller<IRequest, GetDocumentVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDocumentVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetDocumentVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetFields())
            {
                request.Parameters.Add("fields", StringUtils.FromString(publicRequest.Fields));
            }

            if (publicRequest.IsSetIncludeCustomMetadata())
            {
                request.Parameters.Add("includeCustomMetadata", StringUtils.FromBool(publicRequest.IncludeCustomMetadata.Value));
            }

            if (publicRequest.IsSetAuthenticationToken())
            {
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;
            }

            if (!publicRequest.IsSetDocumentId())
            {
                throw new AmazonWorkDocsException("Request object does not have required field DocumentId set");
            }
            request.AddPathResource("{DocumentId}", StringUtils.FromString(publicRequest.DocumentId));

            if (!publicRequest.IsSetVersionId())
            {
                throw new AmazonWorkDocsException("Request object does not have required field VersionId set");
            }
            request.AddPathResource("{VersionId}", StringUtils.FromString(publicRequest.VersionId));

            request.ResourcePath = "/api/v1/documents/{DocumentId}/versions/{VersionId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetDocumentVersionRequestMarshaller _instance = new();

        internal static GetDocumentVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetDocumentVersionRequestMarshaller Instance => _instance;
    }
}
