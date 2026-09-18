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

using Amazon.Bedrock.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListCustomModels Request Marshaller
    /// </summary>
    public partial class ListCustomModelsRequestMarshaller : IMarshaller<IRequest, ListCustomModelsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListCustomModelsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListCustomModelsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetBaseModelArnEquals())
            {
                request.Parameters.Add("baseModelArnEquals", StringUtils.FromString(publicRequest.BaseModelArnEquals));
            }

            if (publicRequest.IsSetCreationTimeAfter())
            {
                request.Parameters.Add("creationTimeAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreationTimeAfter));
            }

            if (publicRequest.IsSetCreationTimeBefore())
            {
                request.Parameters.Add("creationTimeBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreationTimeBefore));
            }

            if (publicRequest.IsSetFoundationModelArnEquals())
            {
                request.Parameters.Add("foundationModelArnEquals", StringUtils.FromString(publicRequest.FoundationModelArnEquals));
            }

            if (publicRequest.IsSetIsOwned())
            {
                request.Parameters.Add("isOwned", StringUtils.FromBool(publicRequest.IsOwned.Value));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetModelStatus())
            {
                request.Parameters.Add("modelStatus", StringUtils.FromString(publicRequest.ModelStatus));
            }

            if (publicRequest.IsSetNameContains())
            {
                request.Parameters.Add("nameContains", StringUtils.FromString(publicRequest.NameContains));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetSortBy())
            {
                request.Parameters.Add("sortBy", StringUtils.FromString(publicRequest.SortBy));
            }

            if (publicRequest.IsSetSortOrder())
            {
                request.Parameters.Add("sortOrder", StringUtils.FromString(publicRequest.SortOrder));
            }

            request.ResourcePath = "/custom-models";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListCustomModelsRequestMarshaller _instance = new();

        internal static ListCustomModelsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListCustomModelsRequestMarshaller Instance => _instance;
    }
}
