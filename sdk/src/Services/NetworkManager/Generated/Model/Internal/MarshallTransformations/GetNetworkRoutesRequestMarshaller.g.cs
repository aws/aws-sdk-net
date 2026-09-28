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

using Amazon.NetworkManager.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetNetworkRoutes Request Marshaller
    /// </summary>
    public partial class GetNetworkRoutesRequestMarshaller : IMarshaller<IRequest, GetNetworkRoutesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetNetworkRoutesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetNetworkRoutesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-05";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetGlobalNetworkId())
            {
                throw new AmazonNetworkManagerException("Request object does not have required field GlobalNetworkId set");
            }
            request.AddPathResource("{GlobalNetworkId}", StringUtils.FromString(publicRequest.GlobalNetworkId));

            request.ResourcePath = "/global-networks/{GlobalNetworkId}/network-routes";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetDestinationFilters())
            {
                context.Writer.WritePropertyName("DestinationFilters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestDestinationFiltersKvp in publicRequest.DestinationFilters)
                {
                    context.Writer.WritePropertyName(publicRequestDestinationFiltersKvp.Key);
                    var publicRequestDestinationFiltersValue = publicRequestDestinationFiltersKvp.Value;
                    context.Writer.WriteStartArray();
                    foreach (var publicRequestDestinationFiltersValueListValue in publicRequestDestinationFiltersValue)
                    {
                        context.Writer.WriteStringValue(publicRequestDestinationFiltersValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetExactCidrMatches())
            {
                context.Writer.WritePropertyName("ExactCidrMatches");
                context.Writer.WriteStartArray();
                foreach (var publicRequestExactCidrMatchesListValue in publicRequest.ExactCidrMatches)
                {
                    context.Writer.WriteStringValue(publicRequestExactCidrMatchesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetLongestPrefixMatches())
            {
                context.Writer.WritePropertyName("LongestPrefixMatches");
                context.Writer.WriteStartArray();
                foreach (var publicRequestLongestPrefixMatchesListValue in publicRequest.LongestPrefixMatches)
                {
                    context.Writer.WriteStringValue(publicRequestLongestPrefixMatchesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetPrefixListIds())
            {
                context.Writer.WritePropertyName("PrefixListIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestPrefixListIdsListValue in publicRequest.PrefixListIds)
                {
                    context.Writer.WriteStringValue(publicRequestPrefixListIdsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetRouteTableIdentifier())
            {
                context.Writer.WritePropertyName("RouteTableIdentifier");
                context.Writer.WriteStartObject();

                var marshaller = RouteTableIdentifierMarshaller.Instance;
                marshaller.Marshall(publicRequest.RouteTableIdentifier, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetStates())
            {
                context.Writer.WritePropertyName("States");
                context.Writer.WriteStartArray();
                foreach (var publicRequestStatesListValue in publicRequest.States)
                {
                    context.Writer.WriteStringValue(publicRequestStatesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetSubnetOfMatches())
            {
                context.Writer.WritePropertyName("SubnetOfMatches");
                context.Writer.WriteStartArray();
                foreach (var publicRequestSubnetOfMatchesListValue in publicRequest.SubnetOfMatches)
                {
                    context.Writer.WriteStringValue(publicRequestSubnetOfMatchesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetSupernetOfMatches())
            {
                context.Writer.WritePropertyName("SupernetOfMatches");
                context.Writer.WriteStartArray();
                foreach (var publicRequestSupernetOfMatchesListValue in publicRequest.SupernetOfMatches)
                {
                    context.Writer.WriteStringValue(publicRequestSupernetOfMatchesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetTypes())
            {
                context.Writer.WritePropertyName("Types");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTypesListValue in publicRequest.Types)
                {
                    context.Writer.WriteStringValue(publicRequestTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly GetNetworkRoutesRequestMarshaller _instance = new();

        internal static GetNetworkRoutesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetNetworkRoutesRequestMarshaller Instance => _instance;
    }
}
