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

using Amazon.LocationService.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeletePlaceIndex Request Marshaller
    /// </summary>
    public partial class DeletePlaceIndexRequestMarshaller : IMarshaller<IRequest, DeletePlaceIndexRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeletePlaceIndexRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeletePlaceIndexRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LocationService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetIndexName())
            {
                throw new AmazonLocationServiceException("Request object does not have required field IndexName set");
            }
            request.AddPathResource("{IndexName}", StringUtils.FromString(publicRequest.IndexName));

            request.ResourcePath = "/places/v0/indexes/{IndexName}";

            request.HostPrefix = $"cp.places.";

            return request;
        }

        private static readonly DeletePlaceIndexRequestMarshaller _instance = new();

        internal static DeletePlaceIndexRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeletePlaceIndexRequestMarshaller Instance => _instance;
    }
}
