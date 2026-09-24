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
    /// GetTimeSeriesDataPoint Request Marshaller
    /// </summary>
    public partial class GetTimeSeriesDataPointRequestMarshaller : IMarshaller<IRequest, GetTimeSeriesDataPointRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTimeSeriesDataPointRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetTimeSeriesDataPointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.FormName))
            {
                throw new AmazonDataZoneException("Request object does not have required field FormName set");
            }

            if (publicRequest.IsSetFormName())
            {
                request.Parameters.Add("formName", StringUtils.FromString(publicRequest.FormName));
            }

            if (!publicRequest.IsSetDomainIdentifier())
            {
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            }
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));

            if (!publicRequest.IsSetEntityIdentifier())
            {
                throw new AmazonDataZoneException("Request object does not have required field EntityIdentifier set");
            }
            request.AddPathResource("{entityIdentifier}", StringUtils.FromString(publicRequest.EntityIdentifier));

            if (!publicRequest.IsSetEntityType())
            {
                throw new AmazonDataZoneException("Request object does not have required field EntityType set");
            }
            request.AddPathResource("{entityType}", StringUtils.FromString(publicRequest.EntityType));

            if (!publicRequest.IsSetIdentifier())
            {
                throw new AmazonDataZoneException("Request object does not have required field Identifier set");
            }
            request.AddPathResource("{identifier}", StringUtils.FromString(publicRequest.Identifier));

            request.ResourcePath = "/v2/domains/{domainIdentifier}/entities/{entityType}/{entityIdentifier}/time-series-data-points/{identifier}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetTimeSeriesDataPointRequestMarshaller _instance = new();

        internal static GetTimeSeriesDataPointRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetTimeSeriesDataPointRequestMarshaller Instance => _instance;
    }
}
