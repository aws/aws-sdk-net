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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KafkaConnect.Model;
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
namespace Amazon.KafkaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateConnector Request Marshaller
    /// </summary>       
    public class CreateConnectorRequestMarshaller : IMarshaller<IRequest, CreateConnectorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateConnectorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateConnectorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KafkaConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-09-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/connectors";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCapacity())
            {
                context.Writer.WritePropertyName("capacity");
                context.Writer.WriteStartObject();

                var marshaller = CapacityMarshaller.Instance;
                marshaller.Marshall(publicRequest.Capacity, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetConnectorConfiguration())
            {
                context.Writer.WritePropertyName("connectorConfiguration");
                context.Writer.WriteStartObject();
                foreach (var publicRequestConnectorConfigurationKvp in publicRequest.ConnectorConfiguration)
                {
                    context.Writer.WritePropertyName(publicRequestConnectorConfigurationKvp.Key);
                    var publicRequestConnectorConfigurationValue = publicRequestConnectorConfigurationKvp.Value;

                        context.Writer.WriteStringValue(publicRequestConnectorConfigurationValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetConnectorDescription())
            {
                context.Writer.WritePropertyName("connectorDescription");
                context.Writer.WriteStringValue(publicRequest.ConnectorDescription);
            }

            if(publicRequest.IsSetConnectorName())
            {
                context.Writer.WritePropertyName("connectorName");
                context.Writer.WriteStringValue(publicRequest.ConnectorName);
            }

            if(publicRequest.IsSetKafkaCluster())
            {
                context.Writer.WritePropertyName("kafkaCluster");
                context.Writer.WriteStartObject();

                var marshaller = KafkaClusterMarshaller.Instance;
                marshaller.Marshall(publicRequest.KafkaCluster, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKafkaClusterClientAuthentication())
            {
                context.Writer.WritePropertyName("kafkaClusterClientAuthentication");
                context.Writer.WriteStartObject();

                var marshaller = KafkaClusterClientAuthenticationMarshaller.Instance;
                marshaller.Marshall(publicRequest.KafkaClusterClientAuthentication, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKafkaClusterEncryptionInTransit())
            {
                context.Writer.WritePropertyName("kafkaClusterEncryptionInTransit");
                context.Writer.WriteStartObject();

                var marshaller = KafkaClusterEncryptionInTransitMarshaller.Instance;
                marshaller.Marshall(publicRequest.KafkaClusterEncryptionInTransit, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKafkaConnectVersion())
            {
                context.Writer.WritePropertyName("kafkaConnectVersion");
                context.Writer.WriteStringValue(publicRequest.KafkaConnectVersion);
            }

            if(publicRequest.IsSetLogDelivery())
            {
                context.Writer.WritePropertyName("logDelivery");
                context.Writer.WriteStartObject();

                var marshaller = LogDeliveryMarshaller.Instance;
                marshaller.Marshall(publicRequest.LogDelivery, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPlugins())
            {
                context.Writer.WritePropertyName("plugins");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPluginsListValue in publicRequest.Plugins)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PluginMarshaller.Instance;
                    marshaller.Marshall(publicRequestPluginsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetServiceExecutionRoleArn())
            {
                context.Writer.WritePropertyName("serviceExecutionRoleArn");
                context.Writer.WriteStringValue(publicRequest.ServiceExecutionRoleArn);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWorkerConfiguration())
            {
                context.Writer.WritePropertyName("workerConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = WorkerConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.WorkerConfiguration, context);

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
        private static CreateConnectorRequestMarshaller _instance = new CreateConnectorRequestMarshaller();        

        internal static CreateConnectorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateConnectorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}