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
    /// CreateDatasetImportJob Request Marshaller
    /// </summary>       
    public class CreateDatasetImportJobRequestMarshaller : IMarshaller<IRequest, CreateDatasetImportJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDatasetImportJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDatasetImportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ForecastService");
            string target = "AmazonForecast.CreateDatasetImportJob";
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
            if(publicRequest.IsSetDatasetArn())
            {
                context.Writer.WritePropertyName("DatasetArn");
                context.Writer.WriteStringValue(publicRequest.DatasetArn);
            }

            if(publicRequest.IsSetDatasetImportJobName())
            {
                context.Writer.WritePropertyName("DatasetImportJobName");
                context.Writer.WriteStringValue(publicRequest.DatasetImportJobName);
            }

            if(publicRequest.IsSetDataSource())
            {
                context.Writer.WritePropertyName("DataSource");
                context.Writer.WriteStartObject();

                var marshaller = DataSourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataSource, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFormat())
            {
                context.Writer.WritePropertyName("Format");
                context.Writer.WriteStringValue(publicRequest.Format);
            }

            if(publicRequest.IsSetGeolocationFormat())
            {
                context.Writer.WritePropertyName("GeolocationFormat");
                context.Writer.WriteStringValue(publicRequest.GeolocationFormat);
            }

            if(publicRequest.IsSetImportMode())
            {
                context.Writer.WritePropertyName("ImportMode");
                context.Writer.WriteStringValue(publicRequest.ImportMode);
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

            if(publicRequest.IsSetTimestampFormat())
            {
                context.Writer.WritePropertyName("TimestampFormat");
                context.Writer.WriteStringValue(publicRequest.TimestampFormat);
            }

            if(publicRequest.IsSetTimeZone())
            {
                context.Writer.WritePropertyName("TimeZone");
                context.Writer.WriteStringValue(publicRequest.TimeZone);
            }

            if(publicRequest.IsSetUseGeolocationForTimeZone())
            {
                context.Writer.WritePropertyName("UseGeolocationForTimeZone");
                context.Writer.WriteBooleanValue(publicRequest.UseGeolocationForTimeZone.Value);
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
        private static CreateDatasetImportJobRequestMarshaller _instance = new CreateDatasetImportJobRequestMarshaller();        

        internal static CreateDatasetImportJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDatasetImportJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}