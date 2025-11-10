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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCluster Request Marshaller
    /// </summary>       
    public class CreateClusterRequestMarshaller : IMarshaller<IRequest, CreateClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateClusterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kafka");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/clusters";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBrokerNodeGroupInfo())
                {
                    context.Writer.WritePropertyName("brokerNodeGroupInfo");
                    context.Writer.WriteObjectStart();

                    var marshaller = BrokerNodeGroupInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BrokerNodeGroupInfo, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientAuthentication())
                {
                    context.Writer.WritePropertyName("clientAuthentication");
                    context.Writer.WriteObjectStart();

                    var marshaller = ClientAuthenticationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ClientAuthentication, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClusterName())
                {
                    context.Writer.WritePropertyName("clusterName");
                    context.Writer.Write(publicRequest.ClusterName);
                }

                if(publicRequest.IsSetConfigurationInfo())
                {
                    context.Writer.WritePropertyName("configurationInfo");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConfigurationInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ConfigurationInfo, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEncryptionInfo())
                {
                    context.Writer.WritePropertyName("encryptionInfo");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionInfo, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEnhancedMonitoring())
                {
                    context.Writer.WritePropertyName("enhancedMonitoring");
                    context.Writer.Write(publicRequest.EnhancedMonitoring);
                }

                if(publicRequest.IsSetKafkaVersion())
                {
                    context.Writer.WritePropertyName("kafkaVersion");
                    context.Writer.Write(publicRequest.KafkaVersion);
                }

                if(publicRequest.IsSetLoggingInfo())
                {
                    context.Writer.WritePropertyName("loggingInfo");
                    context.Writer.WriteObjectStart();

                    var marshaller = LoggingInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LoggingInfo, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNumberOfBrokerNodes())
                {
                    context.Writer.WritePropertyName("numberOfBrokerNodes");
                    context.Writer.Write(publicRequest.NumberOfBrokerNodes);
                }

                if(publicRequest.IsSetOpenMonitoring())
                {
                    context.Writer.WritePropertyName("openMonitoring");
                    context.Writer.WriteObjectStart();

                    var marshaller = OpenMonitoringInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OpenMonitoring, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRebalancing())
                {
                    context.Writer.WritePropertyName("rebalancing");
                    context.Writer.WriteObjectStart();

                    var marshaller = RebalancingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Rebalancing, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStorageMode())
                {
                    context.Writer.WritePropertyName("storageMode");
                    context.Writer.Write(publicRequest.StorageMode);
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateClusterRequestMarshaller _instance = new CreateClusterRequestMarshaller();        

        internal static CreateClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}