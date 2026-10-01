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

using Amazon.LexModelBuildingService.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetBotChannelAssociations Request Marshaller
    /// </summary>
    public partial class GetBotChannelAssociationsRequestMarshaller : IMarshaller<IRequest, GetBotChannelAssociationsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetBotChannelAssociationsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetBotChannelAssociationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelBuildingService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-04-19";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNameContains())
            {
                request.Parameters.Add("nameContains", StringUtils.FromString(publicRequest.NameContains));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (!publicRequest.IsSetBotAlias())
            {
                throw new AmazonLexModelBuildingServiceException("Request object does not have required field BotAlias set");
            }
            request.AddPathResource("{botAlias}", StringUtils.FromString(publicRequest.BotAlias));

            if (!publicRequest.IsSetBotName())
            {
                throw new AmazonLexModelBuildingServiceException("Request object does not have required field BotName set");
            }
            request.AddPathResource("{botName}", StringUtils.FromString(publicRequest.BotName));

            request.ResourcePath = "/bots/{botName}/aliases/{botAlias}/channels";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetBotChannelAssociationsRequestMarshaller _instance = new();

        internal static GetBotChannelAssociationsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetBotChannelAssociationsRequestMarshaller Instance => _instance;
    }
}
