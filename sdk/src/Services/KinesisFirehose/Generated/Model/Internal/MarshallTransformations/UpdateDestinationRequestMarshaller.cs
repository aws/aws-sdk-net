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
    /// UpdateDestination Request Marshaller
    /// </summary>       
    public class UpdateDestinationRequestMarshaller : IMarshaller<IRequest, UpdateDestinationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDestinationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDestinationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KinesisFirehose");
            string target = "Firehose_20150804.UpdateDestination";
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
            if(publicRequest.IsSetAmazonOpenSearchServerlessDestinationUpdate())
            {
                context.Writer.WritePropertyName("AmazonOpenSearchServerlessDestinationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = AmazonOpenSearchServerlessDestinationUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.AmazonOpenSearchServerlessDestinationUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAmazonopensearchserviceDestinationUpdate())
            {
                context.Writer.WritePropertyName("AmazonopensearchserviceDestinationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = AmazonopensearchserviceDestinationUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.AmazonopensearchserviceDestinationUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCurrentDeliveryStreamVersionId())
            {
                context.Writer.WritePropertyName("CurrentDeliveryStreamVersionId");
                context.Writer.WriteStringValue(publicRequest.CurrentDeliveryStreamVersionId);
            }

            if(publicRequest.IsSetDeliveryStreamName())
            {
                context.Writer.WritePropertyName("DeliveryStreamName");
                context.Writer.WriteStringValue(publicRequest.DeliveryStreamName);
            }

            if(publicRequest.IsSetDestinationId())
            {
                context.Writer.WritePropertyName("DestinationId");
                context.Writer.WriteStringValue(publicRequest.DestinationId);
            }

            if(publicRequest.IsSetElasticsearchDestinationUpdate())
            {
                context.Writer.WritePropertyName("ElasticsearchDestinationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = ElasticsearchDestinationUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.ElasticsearchDestinationUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExtendedS3DestinationUpdate())
            {
                context.Writer.WritePropertyName("ExtendedS3DestinationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = ExtendedS3DestinationUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExtendedS3DestinationUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetHttpEndpointDestinationUpdate())
            {
                context.Writer.WritePropertyName("HttpEndpointDestinationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = HttpEndpointDestinationUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.HttpEndpointDestinationUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIcebergDestinationUpdate())
            {
                context.Writer.WritePropertyName("IcebergDestinationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = IcebergDestinationUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.IcebergDestinationUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRedshiftDestinationUpdate())
            {
                context.Writer.WritePropertyName("RedshiftDestinationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftDestinationUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.RedshiftDestinationUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetS3DestinationUpdate())
            {
                context.Writer.WritePropertyName("S3DestinationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = S3DestinationUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.S3DestinationUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSnowflakeDestinationUpdate())
            {
                context.Writer.WritePropertyName("SnowflakeDestinationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = SnowflakeDestinationUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.SnowflakeDestinationUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSplunkDestinationUpdate())
            {
                context.Writer.WritePropertyName("SplunkDestinationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = SplunkDestinationUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.SplunkDestinationUpdate, context);

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
        private static UpdateDestinationRequestMarshaller _instance = new UpdateDestinationRequestMarshaller();        

        internal static UpdateDestinationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDestinationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}