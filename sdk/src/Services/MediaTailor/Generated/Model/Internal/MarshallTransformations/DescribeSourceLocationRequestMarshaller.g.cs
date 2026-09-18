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

using Amazon.MediaTailor.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeSourceLocation Request Marshaller
    /// </summary>
    public partial class DescribeSourceLocationRequestMarshaller : IMarshaller<IRequest, DescribeSourceLocationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeSourceLocationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeSourceLocationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaTailor");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-23";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetSourceLocationName())
            {
                throw new AmazonMediaTailorException("Request object does not have required field SourceLocationName set");
            }
            request.AddPathResource("{SourceLocationName}", StringUtils.FromString(publicRequest.SourceLocationName));

            request.ResourcePath = "/sourceLocation/{SourceLocationName}";

            return request;
        }

        private static readonly DescribeSourceLocationRequestMarshaller _instance = new();

        internal static DescribeSourceLocationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeSourceLocationRequestMarshaller Instance => _instance;
    }
}
