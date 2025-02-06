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
    /// CreateBatchLoadTask Request Marshaller
    /// </summary>       
    public class CreateBatchLoadTaskRequestMarshaller : IMarshaller<IRequest, CreateBatchLoadTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBatchLoadTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBatchLoadTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TimestreamWrite");
            string target = "Timestream_20181101.CreateBatchLoadTask";
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
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetDataModelConfiguration())
            {
                context.Writer.WritePropertyName("DataModelConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DataModelConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataModelConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDataSourceConfiguration())
            {
                context.Writer.WritePropertyName("DataSourceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DataSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataSourceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRecordVersion())
            {
                context.Writer.WritePropertyName("RecordVersion");
                context.Writer.WriteNumberValue(publicRequest.RecordVersion.Value);
            }

            if(publicRequest.IsSetReportConfiguration())
            {
                context.Writer.WritePropertyName("ReportConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ReportConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ReportConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTargetDatabaseName())
            {
                context.Writer.WritePropertyName("TargetDatabaseName");
                context.Writer.WriteStringValue(publicRequest.TargetDatabaseName);
            }

            if(publicRequest.IsSetTargetTableName())
            {
                context.Writer.WritePropertyName("TargetTableName");
                context.Writer.WriteStringValue(publicRequest.TargetTableName);
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
        private static CreateBatchLoadTaskRequestMarshaller _instance = new CreateBatchLoadTaskRequestMarshaller();        

        internal static CreateBatchLoadTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBatchLoadTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}