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
using ThirdParty.Json.LitJson;

namespace Amazon.NetworkManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetNetworkRoutes Request Marshaller
    /// </summary>       
    public class GetNetworkRoutesRequestMarshaller : IMarshaller<IRequest, GetNetworkRoutesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetNetworkRoutesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetNetworkRoutesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-05";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetGlobalNetworkId())
                throw new AmazonNetworkManagerException("Request object does not have required field GlobalNetworkId set");
            request.AddPathResource("{globalNetworkId}", StringUtils.FromString(publicRequest.GlobalNetworkId));
            request.ResourcePath = "/global-networks/{globalNetworkId}/network-routes";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDestinationFilters())
                {
                    context.Writer.WritePropertyName("DestinationFilters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestDestinationFiltersKvp in publicRequest.DestinationFilters)
                    {
                        context.Writer.WritePropertyName(publicRequestDestinationFiltersKvp.Key);
                        var publicRequestDestinationFiltersValue = publicRequestDestinationFiltersKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestDestinationFiltersValueListValue in publicRequestDestinationFiltersValue)
                        {
                                context.Writer.Write(publicRequestDestinationFiltersValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExactCidrMatches())
                {
                    context.Writer.WritePropertyName("ExactCidrMatches");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestExactCidrMatchesListValue in publicRequest.ExactCidrMatches)
                    {
                            context.Writer.Write(publicRequestExactCidrMatchesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLongestPrefixMatches())
                {
                    context.Writer.WritePropertyName("LongestPrefixMatches");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLongestPrefixMatchesListValue in publicRequest.LongestPrefixMatches)
                    {
                            context.Writer.Write(publicRequestLongestPrefixMatchesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPrefixListIds())
                {
                    context.Writer.WritePropertyName("PrefixListIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPrefixListIdsListValue in publicRequest.PrefixListIds)
                    {
                            context.Writer.Write(publicRequestPrefixListIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRouteTableIdentifier())
                {
                    context.Writer.WritePropertyName("RouteTableIdentifier");
                    context.Writer.WriteObjectStart();

                    var marshaller = RouteTableIdentifierMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RouteTableIdentifier, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStates())
                {
                    context.Writer.WritePropertyName("States");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStatesListValue in publicRequest.States)
                    {
                            context.Writer.Write(publicRequestStatesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSubnetOfMatches())
                {
                    context.Writer.WritePropertyName("SubnetOfMatches");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubnetOfMatchesListValue in publicRequest.SubnetOfMatches)
                    {
                            context.Writer.Write(publicRequestSubnetOfMatchesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSupernetOfMatches())
                {
                    context.Writer.WritePropertyName("SupernetOfMatches");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSupernetOfMatchesListValue in publicRequest.SupernetOfMatches)
                    {
                            context.Writer.Write(publicRequestSupernetOfMatchesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTypes())
                {
                    context.Writer.WritePropertyName("Types");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTypesListValue in publicRequest.Types)
                    {
                            context.Writer.Write(publicRequestTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetNetworkRoutesRequestMarshaller _instance = new GetNetworkRoutesRequestMarshaller();        

        internal static GetNetworkRoutesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetNetworkRoutesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}