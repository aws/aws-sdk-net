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

using Amazon.Greengrass.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSubscriptionDefinitionVersion Request Marshaller
    /// </summary>
    public partial class GetSubscriptionDefinitionVersionRequestMarshaller : IMarshaller<IRequest, GetSubscriptionDefinitionVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSubscriptionDefinitionVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetSubscriptionDefinitionVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-06-07";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (!publicRequest.IsSetSubscriptionDefinitionId())
            {
                throw new AmazonGreengrassException("Request object does not have required field SubscriptionDefinitionId set");
            }
            request.AddPathResource("{SubscriptionDefinitionId}", StringUtils.FromString(publicRequest.SubscriptionDefinitionId));

            if (!publicRequest.IsSetSubscriptionDefinitionVersionId())
            {
                throw new AmazonGreengrassException("Request object does not have required field SubscriptionDefinitionVersionId set");
            }
            request.AddPathResource("{SubscriptionDefinitionVersionId}", StringUtils.FromString(publicRequest.SubscriptionDefinitionVersionId));

            request.ResourcePath = "/greengrass/definition/subscriptions/{SubscriptionDefinitionId}/versions/{SubscriptionDefinitionVersionId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetSubscriptionDefinitionVersionRequestMarshaller _instance = new();

        internal static GetSubscriptionDefinitionVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetSubscriptionDefinitionVersionRequestMarshaller Instance => _instance;
    }
}
