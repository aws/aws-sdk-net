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
    /// GetMapTile Request Marshaller
    /// </summary>
    public partial class GetMapTileRequestMarshaller : IMarshaller<IRequest, GetMapTileRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetMapTileRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetMapTileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LocationService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetKey())
            {
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            }

            if (!publicRequest.IsSetMapName())
            {
                throw new AmazonLocationServiceException("Request object does not have required field MapName set");
            }
            request.AddPathResource("{MapName}", StringUtils.FromString(publicRequest.MapName));

            if (!publicRequest.IsSetX())
            {
                throw new AmazonLocationServiceException("Request object does not have required field X set");
            }
            request.AddPathResource("{X}", StringUtils.FromString(publicRequest.X));

            if (!publicRequest.IsSetY())
            {
                throw new AmazonLocationServiceException("Request object does not have required field Y set");
            }
            request.AddPathResource("{Y}", StringUtils.FromString(publicRequest.Y));

            if (!publicRequest.IsSetZ())
            {
                throw new AmazonLocationServiceException("Request object does not have required field Z set");
            }
            request.AddPathResource("{Z}", StringUtils.FromString(publicRequest.Z));

            request.ResourcePath = "/maps/v0/maps/{MapName}/tiles/{Z}/{X}/{Y}";

            request.UseQueryString = true;

            request.HostPrefix = $"maps.";

            return request;
        }

        private static readonly GetMapTileRequestMarshaller _instance = new();

        internal static GetMapTileRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetMapTileRequestMarshaller Instance => _instance;
    }
}
