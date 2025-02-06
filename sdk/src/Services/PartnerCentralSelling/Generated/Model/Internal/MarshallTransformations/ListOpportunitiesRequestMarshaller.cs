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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
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
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListOpportunities Request Marshaller
    /// </summary>       
    public class ListOpportunitiesRequestMarshaller : IMarshaller<IRequest, ListOpportunitiesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListOpportunitiesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListOpportunitiesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralSelling");
            string target = "AWSPartnerCentralSelling.ListOpportunities";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCatalog())
            {
                context.Writer.WritePropertyName("Catalog");
                context.Writer.WriteStringValue(publicRequest.Catalog);
            }

            if(publicRequest.IsSetCustomerCompanyName())
            {
                context.Writer.WritePropertyName("CustomerCompanyName");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCustomerCompanyNameListValue in publicRequest.CustomerCompanyName)
                {
                        context.Writer.WriteStringValue(publicRequestCustomerCompanyNameListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIdentifier())
            {
                context.Writer.WritePropertyName("Identifier");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIdentifierListValue in publicRequest.Identifier)
                {
                        context.Writer.WriteStringValue(publicRequestIdentifierListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLastModifiedDate())
            {
                context.Writer.WritePropertyName("LastModifiedDate");
                context.Writer.WriteStartObject();

                var marshaller = LastModifiedDateMarshaller.Instance;
                marshaller.Marshall(publicRequest.LastModifiedDate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLifeCycleReviewStatus())
            {
                context.Writer.WritePropertyName("LifeCycleReviewStatus");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLifeCycleReviewStatusListValue in publicRequest.LifeCycleReviewStatus)
                {
                        context.Writer.WriteStringValue(publicRequestLifeCycleReviewStatusListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLifeCycleStage())
            {
                context.Writer.WritePropertyName("LifeCycleStage");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLifeCycleStageListValue in publicRequest.LifeCycleStage)
                {
                        context.Writer.WriteStringValue(publicRequestLifeCycleStageListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetSort())
            {
                context.Writer.WritePropertyName("Sort");
                context.Writer.WriteStartObject();

                var marshaller = OpportunitySortMarshaller.Instance;
                marshaller.Marshall(publicRequest.Sort, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static ListOpportunitiesRequestMarshaller _instance = new ListOpportunitiesRequestMarshaller();        

        internal static ListOpportunitiesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListOpportunitiesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}