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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTAnalytics.Model;
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
namespace Amazon.IoTAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDatastore Request Marshaller
    /// </summary>       
    public class UpdateDatastoreRequestMarshaller : IMarshaller<IRequest, UpdateDatastoreRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDatastoreRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDatastoreRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTAnalytics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-27";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetDatastoreName())
                throw new AmazonIoTAnalyticsException("Request object does not have required field DatastoreName set");
            request.AddPathResource("{datastoreName}", StringUtils.FromString(publicRequest.DatastoreName));
            request.ResourcePath = "/datastores/{datastoreName}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDatastoreStorage())
            {
                context.Writer.WritePropertyName("datastoreStorage");
                context.Writer.WriteStartObject();

                var marshaller = DatastoreStorageMarshaller.Instance;
                marshaller.Marshall(publicRequest.DatastoreStorage, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFileFormatConfiguration())
            {
                context.Writer.WritePropertyName("fileFormatConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = FileFormatConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.FileFormatConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRetentionPeriod())
            {
                context.Writer.WritePropertyName("retentionPeriod");
                context.Writer.WriteStartObject();

                var marshaller = RetentionPeriodMarshaller.Instance;
                marshaller.Marshall(publicRequest.RetentionPeriod, context);

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
        private static UpdateDatastoreRequestMarshaller _instance = new UpdateDatastoreRequestMarshaller();        

        internal static UpdateDatastoreRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDatastoreRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}