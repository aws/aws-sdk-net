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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoPlaces.Model;
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
namespace Amazon.GeoPlaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReverseGeocode Request Marshaller
    /// </summary>       
    public class ReverseGeocodeRequestMarshaller : IMarshaller<IRequest, ReverseGeocodeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReverseGeocodeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ReverseGeocodeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GeoPlaces");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetKey())
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            request.ResourcePath = "/reverse-geocode";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAdditionalFeatures())
            {
                context.Writer.WritePropertyName("AdditionalFeatures");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAdditionalFeaturesListValue in publicRequest.AdditionalFeatures)
                {
                        context.Writer.WriteStringValue(publicRequestAdditionalFeaturesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFilter())
            {
                context.Writer.WritePropertyName("Filter");
                context.Writer.WriteStartObject();

                var marshaller = ReverseGeocodeFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.Filter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIntendedUse())
            {
                context.Writer.WritePropertyName("IntendedUse");
                context.Writer.WriteStringValue(publicRequest.IntendedUse);
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

            if(publicRequest.IsSetPoliticalView())
            {
                context.Writer.WritePropertyName("PoliticalView");
                context.Writer.WriteStringValue(publicRequest.PoliticalView);
            }

            if(publicRequest.IsSetQueryPosition())
            {
                context.Writer.WritePropertyName("QueryPosition");
                context.Writer.WriteStartArray();
                foreach(var publicRequestQueryPositionListValue in publicRequest.QueryPosition)
                {
                        context.Writer.WriteNumberValue(publicRequestQueryPositionListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetQueryRadius())
            {
                context.Writer.WritePropertyName("QueryRadius");
                context.Writer.WriteNumberValue(publicRequest.QueryRadius.Value);
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
        private static ReverseGeocodeRequestMarshaller _instance = new ReverseGeocodeRequestMarshaller();        

        internal static ReverseGeocodeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReverseGeocodeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}