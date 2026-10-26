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

using Amazon.Pinpoint.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSegmentVersion Request Marshaller
    /// </summary>
    public partial class GetSegmentVersionRequestMarshaller : IMarshaller<IRequest, GetSegmentVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSegmentVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetSegmentVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Pinpoint");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetApplicationId())
            {
                throw new AmazonPinpointException("Request object does not have required field ApplicationId set");
            }
            request.AddPathResource("{ApplicationId}", StringUtils.FromString(publicRequest.ApplicationId));

            if (!publicRequest.IsSetSegmentId())
            {
                throw new AmazonPinpointException("Request object does not have required field SegmentId set");
            }
            request.AddPathResource("{SegmentId}", StringUtils.FromString(publicRequest.SegmentId));

            if (!publicRequest.IsSetVersion())
            {
                throw new AmazonPinpointException("Request object does not have required field Version set");
            }
            request.AddPathResource("{Version}", StringUtils.FromString(publicRequest.Version));

            request.ResourcePath = "/v1/apps/{ApplicationId}/segments/{SegmentId}/versions/{Version}";

            return request;
        }

        private static readonly GetSegmentVersionRequestMarshaller _instance = new();

        internal static GetSegmentVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetSegmentVersionRequestMarshaller Instance => _instance;
    }
}
