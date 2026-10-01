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

using Amazon.AppSync.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSourceApiAssociation Request Marshaller
    /// </summary>
    public partial class GetSourceApiAssociationRequestMarshaller : IMarshaller<IRequest, GetSourceApiAssociationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSourceApiAssociationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetSourceApiAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppSync");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAssociationId())
            {
                throw new AmazonAppSyncException("Request object does not have required field AssociationId set");
            }
            request.AddPathResource("{associationId}", StringUtils.FromString(publicRequest.AssociationId));

            if (!publicRequest.IsSetMergedApiIdentifier())
            {
                throw new AmazonAppSyncException("Request object does not have required field MergedApiIdentifier set");
            }
            request.AddPathResource("{mergedApiIdentifier}", StringUtils.FromString(publicRequest.MergedApiIdentifier));

            request.ResourcePath = "/v1/mergedApis/{mergedApiIdentifier}/sourceApiAssociations/{associationId}";

            return request;
        }

        private static readonly GetSourceApiAssociationRequestMarshaller _instance = new();

        internal static GetSourceApiAssociationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetSourceApiAssociationRequestMarshaller Instance => _instance;
    }
}
