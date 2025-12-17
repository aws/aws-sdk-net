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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCapacity())
                {
                    context.Writer.WritePropertyName("capacity");
                    context.Writer.WriteObjectStart();

                    var marshaller = CapacityMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Capacity, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetConnectorConfiguration())
                {
                    context.Writer.WritePropertyName("connectorConfiguration");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestConnectorConfigurationKvp in publicRequest.ConnectorConfiguration)
                    {
                        context.Writer.WritePropertyName(publicRequestConnectorConfigurationKvp.Key);
                        var publicRequestConnectorConfigurationValue = publicRequestConnectorConfigurationKvp.Value;

                            context.Writer.Write(publicRequestConnectorConfigurationValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetConnectorDescription())
                {
                    context.Writer.WritePropertyName("connectorDescription");
                    context.Writer.Write(publicRequest.ConnectorDescription);
                }

                if(publicRequest.IsSetConnectorName())
                {
                    context.Writer.WritePropertyName("connectorName");
                    context.Writer.Write(publicRequest.ConnectorName);
                }

                if(publicRequest.IsSetKafkaCluster())
                {
                    context.Writer.WritePropertyName("kafkaCluster");
                    context.Writer.WriteObjectStart();

                    var marshaller = KafkaClusterMarshaller.Instance;
                    marshaller.Marshall(publicRequest.KafkaCluster, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKafkaClusterClientAuthentication())
                {
                    context.Writer.WritePropertyName("kafkaClusterClientAuthentication");
                    context.Writer.WriteObjectStart();

                    var marshaller = KafkaClusterClientAuthenticationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.KafkaClusterClientAuthentication, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKafkaClusterEncryptionInTransit())
                {
                    context.Writer.WritePropertyName("kafkaClusterEncryptionInTransit");
                    context.Writer.WriteObjectStart();

                    var marshaller = KafkaClusterEncryptionInTransitMarshaller.Instance;
                    marshaller.Marshall(publicRequest.KafkaClusterEncryptionInTransit, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKafkaConnectVersion())
                {
                    context.Writer.WritePropertyName("kafkaConnectVersion");
                    context.Writer.Write(publicRequest.KafkaConnectVersion);
                }

                if(publicRequest.IsSetLogDelivery())
                {
                    context.Writer.WritePropertyName("logDelivery");
                    context.Writer.WriteObjectStart();

                    var marshaller = LogDeliveryMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LogDelivery, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNetworkType())
                {
                    context.Writer.WritePropertyName("networkType");
                    context.Writer.Write(publicRequest.NetworkType);
                }

                if(publicRequest.IsSetPlugins())
                {
                    context.Writer.WritePropertyName("plugins");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPluginsListValue in publicRequest.Plugins)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PluginMarshaller.Instance;
                        marshaller.Marshall(publicRequestPluginsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetServiceExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("serviceExecutionRoleArn");
                    context.Writer.Write(publicRequest.ServiceExecutionRoleArn);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWorkerConfiguration())
                {
                    context.Writer.WritePropertyName("workerConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = WorkerConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.WorkerConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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