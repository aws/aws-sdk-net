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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.PartnerCentralMarketing.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralMarketing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchCampaignTemplates Request Marshaller
    /// </summary>
    public partial class SearchCampaignTemplatesRequestMarshaller : IMarshaller<IRequest, SearchCampaignTemplatesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchCampaignTemplatesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SearchCampaignTemplatesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralMarketing");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-05-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/AWSPartnerDemandGenerator/operation/SearchCampaignTemplates";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAwsServices())
                {
                    context.Writer.WriteTextString("AwsServices");
                    context.Writer.WriteStartArray(publicRequest.AwsServices.Count);
                    foreach (var publicRequestAwsServicesListValue in publicRequest.AwsServices)
                    {
                        context.Writer.WriteTextString(publicRequestAwsServicesListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetCatalog())
                {
                    context.Writer.WriteTextString("Catalog");
                    context.Writer.WriteTextString(publicRequest.Catalog);
                }
                if (publicRequest.IsSetCollection())
                {
                    context.Writer.WriteTextString("Collection");
                    context.Writer.WriteStartArray(publicRequest.Collection.Count);
                    foreach (var publicRequestCollectionListValue in publicRequest.Collection)
                    {
                        context.Writer.WriteTextString(publicRequestCollectionListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetCustomerSegments())
                {
                    context.Writer.WriteTextString("CustomerSegments");
                    context.Writer.WriteStartArray(publicRequest.CustomerSegments.Count);
                    foreach (var publicRequestCustomerSegmentsListValue in publicRequest.CustomerSegments)
                    {
                        context.Writer.WriteTextString(publicRequestCustomerSegmentsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetIndustry())
                {
                    context.Writer.WriteTextString("Industry");
                    context.Writer.WriteStartArray(publicRequest.Industry.Count);
                    foreach (var publicRequestIndustryListValue in publicRequest.Industry)
                    {
                        context.Writer.WriteTextString(publicRequestIndustryListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetLanguage())
                {
                    context.Writer.WriteTextString("Language");
                    context.Writer.WriteStartArray(publicRequest.Language.Count);
                    foreach (var publicRequestLanguageListValue in publicRequest.Language)
                    {
                        context.Writer.WriteTextString(publicRequestLanguageListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetMaxResults())
                {
                    context.Writer.WriteTextString("MaxResults");
                    context.Writer.WriteInt32(publicRequest.MaxResults.Value);
                }
                if (publicRequest.IsSetNextToken())
                {
                    context.Writer.WriteTextString("NextToken");
                    context.Writer.WriteTextString(publicRequest.NextToken);
                }
                if (publicRequest.IsSetSearchText())
                {
                    context.Writer.WriteTextString("SearchText");
                    context.Writer.WriteTextString(publicRequest.SearchText);
                }
                if (publicRequest.IsSetThemes())
                {
                    context.Writer.WriteTextString("Themes");
                    context.Writer.WriteStartArray(publicRequest.Themes.Count);
                    foreach (var publicRequestThemesListValue in publicRequest.Themes)
                    {
                        context.Writer.WriteTextString(publicRequestThemesListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetUseCase())
                {
                    context.Writer.WriteTextString("UseCase");
                    context.Writer.WriteStartArray(publicRequest.UseCase.Count);
                    foreach (var publicRequestUseCaseListValue in publicRequest.UseCase)
                    {
                        context.Writer.WriteTextString(publicRequestUseCaseListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly SearchCampaignTemplatesRequestMarshaller _instance = new();

        internal static SearchCampaignTemplatesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SearchCampaignTemplatesRequestMarshaller Instance => _instance;
    }
}
