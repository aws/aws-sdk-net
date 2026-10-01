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

using Amazon.CustomerProfiles.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSegmentEstimate Request Marshaller
    /// </summary>
    public partial class GetSegmentEstimateRequestMarshaller : IMarshaller<IRequest, GetSegmentEstimateRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSegmentEstimateRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetSegmentEstimateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CustomerProfiles");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDomainName())
            {
                throw new AmazonCustomerProfilesException("Request object does not have required field DomainName set");
            }
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));

            if (!publicRequest.IsSetEstimateId())
            {
                throw new AmazonCustomerProfilesException("Request object does not have required field EstimateId set");
            }
            request.AddPathResource("{EstimateId}", StringUtils.FromString(publicRequest.EstimateId));

            request.ResourcePath = "/domains/{DomainName}/segment-estimates/{EstimateId}";

            return request;
        }

        private static readonly GetSegmentEstimateRequestMarshaller _instance = new();

        internal static GetSegmentEstimateRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetSegmentEstimateRequestMarshaller Instance => _instance;
    }
}
