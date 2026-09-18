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

using Amazon.WellArchitected.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListTemplateShares Request Marshaller
    /// </summary>
    public partial class ListTemplateSharesRequestMarshaller : IMarshaller<IRequest, ListTemplateSharesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListTemplateSharesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListTemplateSharesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetSharedWithPrefix())
            {
                request.Parameters.Add("SharedWithPrefix", StringUtils.FromString(publicRequest.SharedWithPrefix));
            }

            if (publicRequest.IsSetStatus())
            {
                request.Parameters.Add("Status", StringUtils.FromString(publicRequest.Status));
            }

            if (!publicRequest.IsSetTemplateArn())
            {
                throw new AmazonWellArchitectedException("Request object does not have required field TemplateArn set");
            }
            request.AddPathResource("{TemplateArn}", StringUtils.FromString(publicRequest.TemplateArn));

            request.ResourcePath = "/templates/shares/{TemplateArn}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListTemplateSharesRequestMarshaller _instance = new();

        internal static ListTemplateSharesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListTemplateSharesRequestMarshaller Instance => _instance;
    }
}
