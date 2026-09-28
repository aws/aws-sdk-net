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

using Amazon.Outposts.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAssetInstances Request Marshaller
    /// </summary>
    public partial class ListAssetInstancesRequestMarshaller : IMarshaller<IRequest, ListAssetInstancesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAssetInstancesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListAssetInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Outposts");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-03";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetAccountIdFilter())
            {
                request.ParameterCollection.Add("AccountIdFilter", publicRequest.AccountIdFilter);
            }

            if (publicRequest.IsSetAssetIdFilter())
            {
                request.ParameterCollection.Add("AssetIdFilter", publicRequest.AssetIdFilter);
            }

            if (publicRequest.IsSetAwsServiceFilter())
            {
                request.ParameterCollection.Add("AwsServiceFilter", publicRequest.AwsServiceFilter);
            }

            if (publicRequest.IsSetInstanceTypeFilter())
            {
                request.ParameterCollection.Add("InstanceTypeFilter", publicRequest.InstanceTypeFilter);
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (!publicRequest.IsSetOutpostIdentifier())
            {
                throw new AmazonOutpostsException("Request object does not have required field OutpostIdentifier set");
            }
            request.AddPathResource("{OutpostIdentifier}", StringUtils.FromString(publicRequest.OutpostIdentifier));

            request.ResourcePath = "/outposts/{OutpostIdentifier}/assetInstances";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListAssetInstancesRequestMarshaller _instance = new();

        internal static ListAssetInstancesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListAssetInstancesRequestMarshaller Instance => _instance;
    }
}
