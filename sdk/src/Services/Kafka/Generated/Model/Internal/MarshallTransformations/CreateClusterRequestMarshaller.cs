/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/v1/clusters";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
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

                if(publicRequest.IsSetClusterName())
                {
                    context.Writer.WritePropertyName("clusterName");
                    context.Writer.Write(publicRequest.ClusterName);
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

                if(publicRequest.IsSetNumberOfBrokerNodes())
                {
                    context.Writer.WritePropertyName("numberOfBrokerNodes");
                    context.Writer.Write(publicRequest.NumberOfBrokerNodes);
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