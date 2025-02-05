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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
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
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDeliveryStream Request Marshaller
    /// </summary>       
    public class CreateDeliveryStreamRequestMarshaller : IMarshaller<IRequest, CreateDeliveryStreamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDeliveryStreamRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDeliveryStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KinesisFirehose");
            string target = "Firehose_20150804.CreateDeliveryStream";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-08-04";
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
            if(publicRequest.IsSetAmazonOpenSearchServerlessDestinationConfiguration())
            {
                context.Writer.WritePropertyName("AmazonOpenSearchServerlessDestinationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AmazonOpenSearchServerlessDestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AmazonOpenSearchServerlessDestinationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAmazonopensearchserviceDestinationConfiguration())
            {
                context.Writer.WritePropertyName("AmazonopensearchserviceDestinationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AmazonopensearchserviceDestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AmazonopensearchserviceDestinationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDatabaseSourceConfiguration())
            {
                context.Writer.WritePropertyName("DatabaseSourceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DatabaseSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DatabaseSourceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeliveryStreamEncryptionConfigurationInput())
            {
                context.Writer.WritePropertyName("DeliveryStreamEncryptionConfigurationInput");
                context.Writer.WriteStartObject();

                var marshaller = DeliveryStreamEncryptionConfigurationInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeliveryStreamEncryptionConfigurationInput, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeliveryStreamName())
            {
                context.Writer.WritePropertyName("DeliveryStreamName");
                context.Writer.WriteStringValue(publicRequest.DeliveryStreamName);
            }

            if(publicRequest.IsSetDeliveryStreamType())
            {
                context.Writer.WritePropertyName("DeliveryStreamType");
                context.Writer.WriteStringValue(publicRequest.DeliveryStreamType);
            }

            if(publicRequest.IsSetDirectPutSourceConfiguration())
            {
                context.Writer.WritePropertyName("DirectPutSourceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DirectPutSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DirectPutSourceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetElasticsearchDestinationConfiguration())
            {
                context.Writer.WritePropertyName("ElasticsearchDestinationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ElasticsearchDestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ElasticsearchDestinationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExtendedS3DestinationConfiguration())
            {
                context.Writer.WritePropertyName("ExtendedS3DestinationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ExtendedS3DestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExtendedS3DestinationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetHttpEndpointDestinationConfiguration())
            {
                context.Writer.WritePropertyName("HttpEndpointDestinationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = HttpEndpointDestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.HttpEndpointDestinationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIcebergDestinationConfiguration())
            {
                context.Writer.WritePropertyName("IcebergDestinationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = IcebergDestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.IcebergDestinationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKinesisStreamSourceConfiguration())
            {
                context.Writer.WritePropertyName("KinesisStreamSourceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = KinesisStreamSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.KinesisStreamSourceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMSKSourceConfiguration())
            {
                context.Writer.WritePropertyName("MSKSourceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = MSKSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.MSKSourceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRedshiftDestinationConfiguration())
            {
                context.Writer.WritePropertyName("RedshiftDestinationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftDestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.RedshiftDestinationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetS3DestinationConfiguration())
            {
                context.Writer.WritePropertyName("S3DestinationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = S3DestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.S3DestinationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSnowflakeDestinationConfiguration())
            {
                context.Writer.WritePropertyName("SnowflakeDestinationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SnowflakeDestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SnowflakeDestinationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSplunkDestinationConfiguration())
            {
                context.Writer.WritePropertyName("SplunkDestinationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SplunkDestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SplunkDestinationConfiguration, context);

                context.Writer.WriteEndObject();
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
        private static CreateDeliveryStreamRequestMarshaller _instance = new CreateDeliveryStreamRequestMarshaller();        

        internal static CreateDeliveryStreamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDeliveryStreamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}