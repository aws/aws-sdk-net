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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
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
namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchPlaceIndexForSuggestions Request Marshaller
    /// </summary>       
    public class SearchPlaceIndexForSuggestionsRequestMarshaller : IMarshaller<IRequest, SearchPlaceIndexForSuggestionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchPlaceIndexForSuggestionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchPlaceIndexForSuggestionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LocationService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetIndexName())
                throw new AmazonLocationServiceException("Request object does not have required field IndexName set");
            request.AddPathResource("{IndexName}", StringUtils.FromString(publicRequest.IndexName));
            
            if (publicRequest.IsSetKey())
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            request.ResourcePath = "/places/v0/indexes/{IndexName}/search/suggestions";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBiasPosition())
            {
                context.Writer.WritePropertyName("BiasPosition");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBiasPositionListValue in publicRequest.BiasPosition)
                {
                        context.Writer.WriteNumberValue(publicRequestBiasPositionListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFilterBBox())
            {
                context.Writer.WritePropertyName("FilterBBox");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFilterBBoxListValue in publicRequest.FilterBBox)
                {
                        context.Writer.WriteNumberValue(publicRequestFilterBBoxListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFilterCategories())
            {
                context.Writer.WritePropertyName("FilterCategories");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFilterCategoriesListValue in publicRequest.FilterCategories)
                {
                        context.Writer.WriteStringValue(publicRequestFilterCategoriesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFilterCountries())
            {
                context.Writer.WritePropertyName("FilterCountries");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFilterCountriesListValue in publicRequest.FilterCountries)
                {
                        context.Writer.WriteStringValue(publicRequestFilterCountriesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLanguage())
            {
                context.Writer.WritePropertyName("Language");
                context.Writer.WriteStringValue(publicRequest.Language);
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetText())
            {
                context.Writer.WritePropertyName("Text");
                context.Writer.WriteStringValue(publicRequest.Text);
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
            
            request.HostPrefix = $"places.";

            return request;
        }
        private static SearchPlaceIndexForSuggestionsRequestMarshaller _instance = new SearchPlaceIndexForSuggestionsRequestMarshaller();        

        internal static SearchPlaceIndexForSuggestionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchPlaceIndexForSuggestionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}