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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Private5G.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Private5G.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListNetworkSites Request Marshaller
    /// </summary>       
    public class ListNetworkSitesRequestMarshaller : IMarshaller<IRequest, ListNetworkSitesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListNetworkSitesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListNetworkSitesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Private5G");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-12-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/network-sites/list";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFilters())
                {
                    context.Writer.WritePropertyName("filters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestFiltersKvp in publicRequest.Filters)
                    {
                        context.Writer.WritePropertyName(publicRequestFiltersKvp.Key);
                        var publicRequestFiltersValue = publicRequestFiltersKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestFiltersValueListValue in publicRequestFiltersValue)
                        {
                                context.Writer.Write(publicRequestFiltersValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNetworkArn())
                {
                    context.Writer.WritePropertyName("networkArn");
                    context.Writer.Write(publicRequest.NetworkArn);
                }

                if(publicRequest.IsSetStartToken())
                {
                    context.Writer.WritePropertyName("startToken");
                    context.Writer.Write(publicRequest.StartToken);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListNetworkSitesRequestMarshaller _instance = new ListNetworkSitesRequestMarshaller();        

        internal static ListNetworkSitesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListNetworkSitesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}