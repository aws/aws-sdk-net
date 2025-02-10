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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kafka.Model;
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
namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateReplicationInfo Request Marshaller
    /// </summary>       
    public class UpdateReplicationInfoRequestMarshaller : IMarshaller<IRequest, UpdateReplicationInfoRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateReplicationInfoRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateReplicationInfoRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kafka");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetReplicatorArn())
                throw new AmazonKafkaException("Request object does not have required field ReplicatorArn set");
            request.AddPathResource("{replicatorArn}", StringUtils.FromString(publicRequest.ReplicatorArn));
            request.ResourcePath = "/replication/v1/replicators/{replicatorArn}/replication-info";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetConsumerGroupReplication())
            {
                context.Writer.WritePropertyName("consumerGroupReplication");
                context.Writer.WriteStartObject();

                var marshaller = ConsumerGroupReplicationUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConsumerGroupReplication, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCurrentVersion())
            {
                context.Writer.WritePropertyName("currentVersion");
                context.Writer.WriteStringValue(publicRequest.CurrentVersion);
            }

            if(publicRequest.IsSetSourceKafkaClusterArn())
            {
                context.Writer.WritePropertyName("sourceKafkaClusterArn");
                context.Writer.WriteStringValue(publicRequest.SourceKafkaClusterArn);
            }

            if(publicRequest.IsSetTargetKafkaClusterArn())
            {
                context.Writer.WritePropertyName("targetKafkaClusterArn");
                context.Writer.WriteStringValue(publicRequest.TargetKafkaClusterArn);
            }

            if(publicRequest.IsSetTopicReplication())
            {
                context.Writer.WritePropertyName("topicReplication");
                context.Writer.WriteStartObject();

                var marshaller = TopicReplicationUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.TopicReplication, context);

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
        private static UpdateReplicationInfoRequestMarshaller _instance = new UpdateReplicationInfoRequestMarshaller();        

        internal static UpdateReplicationInfoRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateReplicationInfoRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}