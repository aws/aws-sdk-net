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
    /// GetFolder Request Marshaller
    /// </summary>
    public partial class GetFolderRequestMarshaller : IMarshaller<IRequest, GetFolderRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetFolderRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetFolderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetIncludeCustomMetadata())
            {
                request.Parameters.Add("includeCustomMetadata", StringUtils.FromBool(publicRequest.IncludeCustomMetadata.Value));
            }

            if (publicRequest.IsSetAuthenticationToken())
            {
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;
            }

            if (!publicRequest.IsSetFolderId())
            {
                throw new AmazonWorkDocsException("Request object does not have required field FolderId set");
            }
            request.AddPathResource("{FolderId}", StringUtils.FromString(publicRequest.FolderId));

            request.ResourcePath = "/api/v1/folders/{FolderId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetFolderRequestMarshaller _instance = new();

        internal static GetFolderRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetFolderRequestMarshaller Instance => _instance;
    }
}
