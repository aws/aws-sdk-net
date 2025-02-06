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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ForecastService.Model;
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
namespace Amazon.ForecastService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateExplainability Request Marshaller
    /// </summary>       
    public class CreateExplainabilityRequestMarshaller : IMarshaller<IRequest, CreateExplainabilityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateExplainabilityRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateExplainabilityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ForecastService");
            string target = "AmazonForecast.CreateExplainability";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-26";
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
            if(publicRequest.IsSetDataSource())
            {
                context.Writer.WritePropertyName("DataSource");
                context.Writer.WriteStartObject();

                var marshaller = DataSourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataSource, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEnableVisualization())
            {
                context.Writer.WritePropertyName("EnableVisualization");
                context.Writer.WriteBooleanValue(publicRequest.EnableVisualization.Value);
            }

            if(publicRequest.IsSetEndDateTime())
            {
                context.Writer.WritePropertyName("EndDateTime");
                context.Writer.WriteStringValue(publicRequest.EndDateTime);
            }

            if(publicRequest.IsSetExplainabilityConfig())
            {
                context.Writer.WritePropertyName("ExplainabilityConfig");
                context.Writer.WriteStartObject();

                var marshaller = ExplainabilityConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExplainabilityConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExplainabilityName())
            {
                context.Writer.WritePropertyName("ExplainabilityName");
                context.Writer.WriteStringValue(publicRequest.ExplainabilityName);
            }

            if(publicRequest.IsSetResourceArn())
            {
                context.Writer.WritePropertyName("ResourceArn");
                context.Writer.WriteStringValue(publicRequest.ResourceArn);
            }

            if(publicRequest.IsSetSchema())
            {
                context.Writer.WritePropertyName("Schema");
                context.Writer.WriteStartObject();

                var marshaller = SchemaMarshaller.Instance;
                marshaller.Marshall(publicRequest.Schema, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStartDateTime())
            {
                context.Writer.WritePropertyName("StartDateTime");
                context.Writer.WriteStringValue(publicRequest.StartDateTime);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
        private static CreateExplainabilityRequestMarshaller _instance = new CreateExplainabilityRequestMarshaller();        

        internal static CreateExplainabilityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateExplainabilityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}