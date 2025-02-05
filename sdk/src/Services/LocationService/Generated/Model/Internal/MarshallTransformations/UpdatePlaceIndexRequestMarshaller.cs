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
    /// UpdatePlaceIndex Request Marshaller
    /// </summary>       
    public class UpdatePlaceIndexRequestMarshaller : IMarshaller<IRequest, UpdatePlaceIndexRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePlaceIndexRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePlaceIndexRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LocationService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetIndexName())
                throw new AmazonLocationServiceException("Request object does not have required field IndexName set");
            request.AddPathResource("{IndexName}", StringUtils.FromString(publicRequest.IndexName));
            request.ResourcePath = "/places/v0/indexes/{IndexName}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDataSourceConfiguration())
            {
                context.Writer.WritePropertyName("DataSourceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DataSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataSourceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetPricingPlan())
            {
                context.Writer.WritePropertyName("PricingPlan");
                context.Writer.WriteStringValue(publicRequest.PricingPlan);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"cp.places.";

            return request;
        }
        private static UpdatePlaceIndexRequestMarshaller _instance = new UpdatePlaceIndexRequestMarshaller();        

        internal static UpdatePlaceIndexRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePlaceIndexRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}