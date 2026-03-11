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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListCoreNetworkRoutingInformation Request Marshaller
    /// </summary>       
    public class ListCoreNetworkRoutingInformationRequestMarshaller : IMarshaller<IRequest, ListCoreNetworkRoutingInformationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListCoreNetworkRoutingInformationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListCoreNetworkRoutingInformationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-05";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetCoreNetworkId())
                throw new AmazonNetworkManagerException("Request object does not have required field CoreNetworkId set");
            request.AddPathResource("{coreNetworkId}", StringUtils.FromString(publicRequest.CoreNetworkId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/core-networks/{coreNetworkId}/core-network-routing-information";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCommunityMatches())
            {
                context.Writer.WritePropertyName("CommunityMatches");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCommunityMatchesListValue in publicRequest.CommunityMatches)
                {
                        context.Writer.WriteStringValue(publicRequestCommunityMatchesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEdgeLocation())
            {
                context.Writer.WritePropertyName("EdgeLocation");
                context.Writer.WriteStringValue(publicRequest.EdgeLocation);
            }

            if(publicRequest.IsSetExactAsPathMatches())
            {
                context.Writer.WritePropertyName("ExactAsPathMatches");
                context.Writer.WriteStartArray();
                foreach(var publicRequestExactAsPathMatchesListValue in publicRequest.ExactAsPathMatches)
                {
                        context.Writer.WriteStringValue(publicRequestExactAsPathMatchesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLocalPreferenceMatches())
            {
                context.Writer.WritePropertyName("LocalPreferenceMatches");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLocalPreferenceMatchesListValue in publicRequest.LocalPreferenceMatches)
                {
                        context.Writer.WriteStringValue(publicRequestLocalPreferenceMatchesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMedMatches())
            {
                context.Writer.WritePropertyName("MedMatches");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMedMatchesListValue in publicRequest.MedMatches)
                {
                        context.Writer.WriteStringValue(publicRequestMedMatchesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNextHopFilters())
            {
                context.Writer.WritePropertyName("NextHopFilters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestNextHopFiltersKvp in publicRequest.NextHopFilters)
                {
                    context.Writer.WritePropertyName(publicRequestNextHopFiltersKvp.Key);
                    var publicRequestNextHopFiltersValue = publicRequestNextHopFiltersKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestNextHopFiltersValueListValue in publicRequestNextHopFiltersValue)
                    {
                            context.Writer.WriteStringValue(publicRequestNextHopFiltersValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSegmentName())
            {
                context.Writer.WritePropertyName("SegmentName");
                context.Writer.WriteStringValue(publicRequest.SegmentName);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            request.UseQueryString = true;

            return request;
        }
        private static ListCoreNetworkRoutingInformationRequestMarshaller _instance = new ListCoreNetworkRoutingInformationRequestMarshaller();        

        internal static ListCoreNetworkRoutingInformationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListCoreNetworkRoutingInformationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}