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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamWrite.Model;
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
namespace Amazon.TimestreamWrite.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTable Request Marshaller
    /// </summary>       
    public class UpdateTableRequestMarshaller : IMarshaller<IRequest, UpdateTableRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTableRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTableRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TimestreamWrite");
            string target = "Timestream_20181101.UpdateTable";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-01";
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
            if(publicRequest.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(publicRequest.DatabaseName);
            }

            if(publicRequest.IsSetMagneticStoreWriteProperties())
            {
                context.Writer.WritePropertyName("MagneticStoreWriteProperties");
                context.Writer.WriteStartObject();

                var marshaller = MagneticStoreWritePropertiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.MagneticStoreWriteProperties, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRetentionProperties())
            {
                context.Writer.WritePropertyName("RetentionProperties");
                context.Writer.WriteStartObject();

                var marshaller = RetentionPropertiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.RetentionProperties, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSchema())
            {
                context.Writer.WritePropertyName("Schema");
                context.Writer.WriteStartObject();

                var marshaller = SchemaMarshaller.Instance;
                marshaller.Marshall(publicRequest.Schema, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTableName())
            {
                context.Writer.WritePropertyName("TableName");
                context.Writer.WriteStringValue(publicRequest.TableName);
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
        private static UpdateTableRequestMarshaller _instance = new UpdateTableRequestMarshaller();        

        internal static UpdateTableRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTableRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}