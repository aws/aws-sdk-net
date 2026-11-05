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

using Amazon.Glacier.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListParts Request Marshaller
    /// </summary>
    public partial class ListPartsRequestMarshaller : IMarshaller<IRequest, ListPartsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListPartsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListPartsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glacier");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-06-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetLimit())
            {
                request.Parameters.Add("limit", Amazon.Runtime.Internal.Util.StringUtils.FromInt(publicRequest.Limit));
            }

            if (publicRequest.IsSetMarker())
            {
                request.Parameters.Add("marker", StringUtils.FromString(publicRequest.Marker));
            }

            request.AddPathResource("{accountId}", publicRequest.IsSetAccountId() ? StringUtils.FromString(publicRequest.AccountId) : string.Empty);

            if (!publicRequest.IsSetUploadId())
            {
                throw new AmazonGlacierException("Request object does not have required field UploadId set");
            }
            request.AddPathResource("{uploadId}", StringUtils.FromString(publicRequest.UploadId));

            if (!publicRequest.IsSetVaultName())
            {
                throw new AmazonGlacierException("Request object does not have required field VaultName set");
            }
            request.AddPathResource("{vaultName}", StringUtils.FromString(publicRequest.VaultName));

            request.ResourcePath = "/{accountId}/vaults/{vaultName}/multipart-uploads/{uploadId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListPartsRequestMarshaller _instance = new();

        internal static ListPartsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListPartsRequestMarshaller Instance => _instance;
    }
}
