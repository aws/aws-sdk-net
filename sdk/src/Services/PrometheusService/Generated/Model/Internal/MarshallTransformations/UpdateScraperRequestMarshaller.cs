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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PrometheusService.Model;
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
namespace Amazon.PrometheusService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateScraper Request Marshaller
    /// </summary>       
    public class UpdateScraperRequestMarshaller : IMarshaller<IRequest, UpdateScraperRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateScraperRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateScraperRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PrometheusService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-01";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetScraperId())
                throw new AmazonPrometheusServiceException("Request object does not have required field ScraperId set");
            request.AddPathResource("{scraperId}", StringUtils.FromString(publicRequest.ScraperId));
            request.ResourcePath = "/scrapers/{scraperId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAlias())
            {
                context.Writer.WritePropertyName("alias");
                context.Writer.WriteStringValue(publicRequest.Alias);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.WriteStartObject();

                var marshaller = DestinationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Destination, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoleConfiguration())
            {
                context.Writer.WritePropertyName("roleConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RoleConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.RoleConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetScrapeConfiguration())
            {
                context.Writer.WritePropertyName("scrapeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ScrapeConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ScrapeConfiguration, context);

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
        private static UpdateScraperRequestMarshaller _instance = new UpdateScraperRequestMarshaller();        

        internal static UpdateScraperRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateScraperRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}