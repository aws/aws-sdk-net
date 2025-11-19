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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralChannel.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralChannel.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListChannelHandshakes Request Marshaller
    /// </summary>       
    public class ListChannelHandshakesRequestMarshaller : IMarshaller<IRequest, ListChannelHandshakesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListChannelHandshakesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListChannelHandshakesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralChannel");
            string target = "PartnerCentralChannel.ListChannelHandshakes";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-03-18";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssociatedResourceIdentifiers())
                {
                    context.Writer.WritePropertyName("associatedResourceIdentifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAssociatedResourceIdentifiersListValue in publicRequest.AssociatedResourceIdentifiers)
                    {
                            context.Writer.Write(publicRequestAssociatedResourceIdentifiersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCatalog())
                {
                    context.Writer.WritePropertyName("catalog");
                    context.Writer.Write(publicRequest.Catalog);
                }

                if(publicRequest.IsSetHandshakeType())
                {
                    context.Writer.WritePropertyName("handshakeType");
                    context.Writer.Write(publicRequest.HandshakeType);
                }

                if(publicRequest.IsSetHandshakeTypeFilters())
                {
                    context.Writer.WritePropertyName("handshakeTypeFilters");
                    context.Writer.WriteObjectStart();

                    var marshaller = ListChannelHandshakesTypeFiltersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HandshakeTypeFilters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetHandshakeTypeSort())
                {
                    context.Writer.WritePropertyName("handshakeTypeSort");
                    context.Writer.WriteObjectStart();

                    var marshaller = ListChannelHandshakesTypeSortMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HandshakeTypeSort, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetParticipantType())
                {
                    context.Writer.WritePropertyName("participantType");
                    context.Writer.Write(publicRequest.ParticipantType);
                }

                if(publicRequest.IsSetStatuses())
                {
                    context.Writer.WritePropertyName("statuses");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStatusesListValue in publicRequest.Statuses)
                    {
                            context.Writer.Write(publicRequestStatusesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListChannelHandshakesRequestMarshaller _instance = new ListChannelHandshakesRequestMarshaller();        

        internal static ListChannelHandshakesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListChannelHandshakesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}